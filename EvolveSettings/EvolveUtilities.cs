using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvolveSettings
{
    internal static class EvolveUtilities
    {
        readonly static string DiagnosisAutoLoggerFolder = Path.Combine(CleanHelper.ProgramData, @"Microsoft\Diagnosis\ETLLogs\AutoLogger"); //components for Telemetrytasks

        internal static void DisableTelemetryRunner()
        {
            EvolveUtilities.PreventProcessFromRunning("CompatTelRunner.exe");
            EvolveUtilities.PreventProcessFromRunning("DeviceCensus.exe");
        }

        internal static WindowsVersion CurrentWindowsVersion = WindowsVersion.Unsupported;

        static string productName = string.Empty;
        static string buildNumber = string.Empty;
        internal static bool ServiceExists(string serviceName)
        {
            return Array.Exists(ServiceController.GetServices(), (serviceController => serviceController.ServiceName.Equals(serviceName)));
        }

        internal static void StopService(string serviceName)
        {
            if (ServiceExists(serviceName))
            {
                ServiceController sc = new ServiceController(serviceName);
                if (sc.CanStop)
                {
                    sc.Stop();
                }
            }
        }

        internal static void StartService(string serviceName)
        {
            if (ServiceExists(serviceName))
            {
                ServiceController sc = new ServiceController(serviceName);

                try
                {
                    sc.Start();
                }
                catch (Exception ex)
                {
                    Logger.LogError("EvolveUtilities.StartService", ex.Message, ex.StackTrace);
                }
            }
        }
        internal static void RunBatchFile(string batchFile)
        {
            try
            {
                using (Process p = new Process())
                {
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.FileName = batchFile;
                    p.StartInfo.UseShellExecute = false;

                    p.Start();
                    p.WaitForExit();
                    p.Close();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("EvolveUtilities.RunBatchFile", ex.Message, ex.StackTrace);
            }
        }
        internal static void RunCommand(string command)
        {
            if (string.IsNullOrEmpty(command)) return;

            using (Process p = new Process())
            {
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.Arguments = "/C " + command;
                p.StartInfo.CreateNoWindow = true;

                try
                {
                    p.Start();
                    p.WaitForExit();
                    p.Close();
                }
                catch (Exception ex)
                {
                    Logger.LogError("EvolveUtilities.RunCommand", ex.Message, ex.StackTrace);
                }
            }
        }
        internal static void ImportRegistryScript(string scriptFile)
        {
            string path = "\"" + scriptFile + "\"";

            Process p = new Process();
            try
            {
                p.StartInfo.FileName = "regedit.exe";
                p.StartInfo.UseShellExecute = false;

                p = Process.Start("regedit.exe", "/s " + path);

                p.WaitForExit();
            }
            catch (Exception ex)
            {
                p.Dispose();
                Logger.LogError("EvolveUtilities.ImportRegistryScript", ex.Message, ex.StackTrace);
            }
            finally
            {
                p.Dispose();
            }
        }
        internal static void TryDeleteRegistryValue(bool localMachine, string path, string valueName)
        {
            try
            {
                if (localMachine) Registry.LocalMachine.OpenSubKey(path, true).DeleteValue(valueName, false);
                if (!localMachine) Registry.CurrentUser.OpenSubKey(path, true).DeleteValue(valueName, false);
            }
            catch { }
        }
        internal static void TryDeleteRegistryValueDefaultUsers(string path, string valueName)
        {
            try
            {
                Registry.Users.OpenSubKey(path, true).DeleteValue(valueName, false);
            }
            catch { }
        }
        internal static void DisableProtectedService(string serviceName)
        {
            using (TokenPrivilegeHelper.TakeOwnership)
            {
                using (RegistryKey allServicesKey = Registry.LocalMachine.OpenSubKeyWritable(@"SYSTEM\CurrentControlSet\Services"))
                {
                    allServicesKey.GrantFullControlOnSubKey(serviceName);
                    using (RegistryKey serviceKey = allServicesKey.OpenSubKeyWritable(serviceName))
                    {
                        if (serviceKey == null) return;

                        foreach (string subkeyName in serviceKey.GetSubKeyNames())
                        {
                            serviceKey.TakeOwnershipOnSubKey(subkeyName);
                            serviceKey.GrantFullControlOnSubKey(subkeyName);
                        }
                        serviceKey.SetValue("Start", "4", RegistryValueKind.DWord);
                    }
                }
            }
        }
        internal static void EnableProtectedService(string serviceName)
        {
            using (TokenPrivilegeHelper.TakeOwnership)
            {
                using (RegistryKey allServicesKey = Registry.LocalMachine.OpenSubKeyWritable(@"SYSTEM\CurrentControlSet\Services"))
                {
                    allServicesKey.GrantFullControlOnSubKey(serviceName);
                    using (RegistryKey serviceKey = allServicesKey.OpenSubKeyWritable(serviceName))
                    {
                        if (serviceKey == null) return;

                        foreach (string subkeyName in serviceKey.GetSubKeyNames())
                        {
                            serviceKey.TakeOwnershipOnSubKey(subkeyName);
                            serviceKey.GrantFullControlOnSubKey(subkeyName);
                        }
                        serviceKey.SetValue("Start", "2", RegistryValueKind.DWord);
                    }
                }
            }
        }

        public static RegistryKey OpenSubKeyWritable(this RegistryKey registryKey, string subkeyName, RegistryRights? rights = null)
        {
            RegistryKey subKey;

            if (rights == null)
                subKey = registryKey.OpenSubKey(subkeyName, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl);
            else
                subKey = registryKey.OpenSubKey(subkeyName, RegistryKeyPermissionCheck.ReadWriteSubTree, rights.Value);

            if (subKey == null)
            {
                Logger.LogError("Utilities.OpenSubKeyWritable", $"Subkey {subkeyName} not found.", "-");
            }

            return subKey;
        }

        internal static SecurityIdentifier RetrieveCurrentUserIdentifier()
            => WindowsIdentity.GetCurrent().User ?? throw new Exception("Unable to retrieve current user SID.");

        internal static void GrantFullControlOnSubKey(this RegistryKey registryKey, string subkeyName)
        {
            using (RegistryKey subKey = registryKey.OpenSubKeyWritable(subkeyName,
                RegistryRights.TakeOwnership | RegistryRights.ChangePermissions
            ))
            {
                RegistrySecurity accessRules = subKey.GetAccessControl();
                SecurityIdentifier currentUser = RetrieveCurrentUserIdentifier();
                accessRules.SetOwner(currentUser);
                accessRules.ResetAccessRule(
                    new RegistryAccessRule(
                        currentUser,
                        RegistryRights.FullControl,
                        InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                        PropagationFlags.None,
                        AccessControlType.Allow
                    )
                );
                subKey.SetAccessControl(accessRules);
            }
        }

        internal static void TakeOwnershipOnSubKey(this RegistryKey registryKey, string subkeyName)
        {
            using (RegistryKey subKey = registryKey.OpenSubKeyWritable(subkeyName, RegistryRights.TakeOwnership))
            {
                RegistrySecurity accessRules = subKey.GetAccessControl();
                accessRules.SetOwner(RetrieveCurrentUserIdentifier());
                subKey.SetAccessControl(accessRules);
            }
        }
        internal static void Reboot()
        {
            Process.Start("shutdown.exe", "/r /t 0");
        }
        internal static Task RunAsync(this Process process)
        {
            var tcs = new TaskCompletionSource<object>();
            process.EnableRaisingEvents = true;
            process.Exited += (s, e) => tcs.TrySetResult(null);

            if (!process.Start()) tcs.SetException(new Exception("Failed to start process."));
            return tcs.Task;
        }
        internal static string GetWindowsDetails()
        {
            string bitness = Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";
            if (CurrentWindowsVersion == WindowsVersion.Windows10 || CurrentWindowsVersion == WindowsVersion.Windows11)
            {
                return string.Format("{0} - {1} ({2})", GetOS(), GetWindows10Build(), bitness);
            }
            else
            {
                return string.Format("{0} - ({1})", GetOS(), bitness);
            }
        }

        internal static string GetWindows10Build()
        {
            return (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "DisplayVersion", "");
        }

        internal static string GetOS()
        {
            productName = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductName", "");

            if (productName.Contains("Windows 10"))
            {
                buildNumber = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "CurrentBuild", "");

                if (Convert.ToInt32(buildNumber) >= 22000)
                {
                    productName = productName.Replace("Windows 10", "Windows 11");
                    CurrentWindowsVersion = WindowsVersion.Windows11;
                }
                else
                {
                    CurrentWindowsVersion = WindowsVersion.Windows10;
                }
            }

            if (Program.UNSAFE_MODE)
            {
                if (productName.Contains("Windows Server 2016") || productName.Contains("Windows Server 2019") || productName.Contains("Windows Server 2022"))
                {
                    CurrentWindowsVersion = WindowsVersion.Windows10;
                }
            }

            return productName;
        }

        internal static string GetBitness()
        {
            string bitness;

            if (Environment.Is64BitOperatingSystem)
            {
                bitness = "64-bit edition";
            }
            else
            {
                bitness = "32-bit edition";
            }

            return bitness;
        }
        internal static string GetNETFramework()
        {
            string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";
            int netRelease;

            using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey))
            {
                if (ndpKey != null && ndpKey.GetValue("Release") != null)
                {
                    netRelease = (int)ndpKey.GetValue("Release");
                }
                else
                {
                    return "4.0";
                }
            }

            if (netRelease >= 533320)
                return "4.8.1";
            if (netRelease >= 528040)
                return "4.8";
            if (netRelease >= 461808)
                return "4.7.2";
            if (netRelease >= 461308)
                return "4.7.1";
            if (netRelease >= 460798)
                return "4.7";
            if (netRelease >= 394802)
                return "4.6.2";
            if (netRelease >= 394254)
                return "4.6.1";
            if (netRelease >= 393295)
                return "4.6";
            if (netRelease >= 379893)
                return "4.5.2";
            if (netRelease >= 378675)
                return "4.5.1";
            if (netRelease >= 378389)
                return "4.5";

            return "4.0";
        }
        internal static void RegisterAutoStart()
        {
            try
            {
                using (RegistryKey k = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    k.SetValue("EvolveSettings", Assembly.GetEntryAssembly().Location);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("EvolveUtilities.AddToStartup", ex.Message, ex.StackTrace);
            }
        }

        internal static void UnregisterAutoStart()
        {
            try
            {
                using (RegistryKey k = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    k.DeleteValue("EvolveSettings", false);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("DeleteFromStartup", ex.Message, ex.StackTrace);
            }
        }

        // attempt to enable Local Group Policy Editor on Windows 10 Home editions
        internal static void EnableGPEDitor()
        {
            RunBatchFile(CoreHelper.ScriptsFolder + "GPEditEnablerInHome.bat");
        }
        internal static void PreventProcessFromRunning(string pName)
        {
            try
            {
                using (RegistryKey ifeo = Registry.LocalMachine.OpenSubKeyWritable(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", RegistryRights.FullControl))
                {
                    if (ifeo == null) return;

                    ifeo.GrantFullControlOnSubKey("Image File Execution Options");

                    using (RegistryKey k = ifeo.OpenSubKeyWritable("Image File Execution Options", RegistryRights.FullControl))
                    {
                        if (k == null) return;

                        k.CreateSubKey(pName);
                        k.GrantFullControlOnSubKey(pName);

                        using (RegistryKey f = k.OpenSubKeyWritable(pName, RegistryRights.FullControl))
                        {
                            if (f == null) return;

                            f.SetValue("Debugger", @"%windir%\System32\taskkill.exe");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("EvolveUtilities.PreventProcessFromRunning", ex.Message, ex.StackTrace);
            }
        }

        internal static void RestartExplorer()
        {
            string killexplorer;
            killexplorer = "/c taskkill /f /im explorer.exe";

            System.Diagnostics.Process.Start("cmd.exe", killexplorer);
            System.Threading.Thread.Sleep(500);
            Process.Start(Environment.SystemDirectory + "\\..\\explorer.exe");
        }
        internal static void ClearDNSCache()
        {
            RunCommand("ipconfig /flushdns");
        }

        internal static void Restart(bool withoutRestart = false)
        {
            if (!withoutRestart)
            {
                // BYPASS SINGLE-INSTANCE MECHANISM
                if (Program.MUTEX != null)
                {
                    Program.MUTEX.ReleaseMutex();
                    Program.MUTEX.Dispose();
                    Program.MUTEX = null;
                }

                Application.Restart();
            }
        }

        internal static void ResetAppConfig(bool withoutRestart = false)
        {
            try
            {
                Directory.Delete(CoreHelper.Data2Folder, true);
            }
            catch (Exception ex)
            {
                Logger.LogError("EvolveUtilities.ResetConfiguration", ex.Message, ex.StackTrace);
            }
            finally
            {
                if (!withoutRestart)
                {
                    // BYPASS SINGLE-INSTANCE MECHANISM
                    if (Program.MUTEX != null)
                    {
                        Program.MUTEX.ReleaseMutex();
                        Program.MUTEX.Dispose();
                        Program.MUTEX = null;
                    }

                    Application.Restart();
                }
            }
        }

        internal static string Encrypt(string text, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[16];
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(text);
                            EvolveMessageBox.Show("Your password has been successfully encrypted", "Password Encryptor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
        }

        internal static string Decrypt(string encryptedText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[16];
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            EvolveMessageBox.Show("Your password has been successfully decrypted", "Password Encryptor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}

