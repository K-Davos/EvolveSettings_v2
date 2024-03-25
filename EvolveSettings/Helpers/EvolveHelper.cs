using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace EvolveSettings.Helpers
{
    internal class EvolveHelper
    {
        internal static void SetPerformancePowerPlan()
        {
            try
            {
                EvolveUtilities.RunBatchFile(CoreHelper.ScriptsFolder + "EvolvePerformance.bat");
                EvolveUtilities.RunCommand("powercfg /setactive 9183f4e0-8bdc-47d1-8112-20d0095879ee");

            }
            catch (Exception ex)
            {
                Logger.LogError("EvolveSettings.SetPowerPlan", ex.Message, ex.StackTrace);
            }
        }
        internal static void SetPowerSavingPowerPlan()
        {
            try
            {
                EvolveUtilities.RunBatchFile(CoreHelper.ScriptsFolder + "EvolvePowerSaving.bat");
                EvolveUtilities.RunCommand("powercfg /setactive a1841308-3541-4fab-bc81-f71556f20b4a");
                //Utilities.RestartExplorer();
            }
            catch (Exception ex)
            {
                Logger.LogError("EvolveSettings.SetPowerPlan", ex.Message, ex.StackTrace);
            }
        }

        internal static void GameMode()
        {
            try
            {
                if (!File.Exists(CoreHelper.ScriptsFolder + "GameModeON.cmd"))
                {
                    File.WriteAllText(CoreHelper.ScriptsFolder + "GameModeON.cmd", Properties.Resources.GameModeON);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("EvolveHelper.GameModeON", ex.Message, ex.StackTrace);
            }

            EvolveUtilities.RunBatchFile(CoreHelper.ScriptsFolder + "GameModeON.cmd");
            System.Threading.Thread.Sleep(500);

            Process clear = new Process();
            clear.StartInfo.UseShellExecute = false;
            clear.StartInfo.FileName = @"C:\Program Files (x86)\Evolve\Data\CStandbyList.exe";
            clear.Start();

            /*Process logoff = new Process();
            logoff.StartInfo.UseShellExecute = false;
            logoff.StartInfo.FileName = @"C:\Program Files (x86)\Evolve\Data\logoff.exe";
            logoff.Start();*/
        }

        internal static void DesktopMode()
        {
            try
            {
                if (!File.Exists(CoreHelper.ScriptsFolder + "GameModeOFF.cmd"))
                {
                    File.WriteAllText(CoreHelper.ScriptsFolder + "GameModeOFF.cmd", Properties.Resources.GameModeOFF);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("EvolveHelper.GameModeOFF", ex.Message, ex.StackTrace);
            }

            EvolveUtilities.RunBatchFile(CoreHelper.ScriptsFolder + "GameModeOFF.cmd");
            System.Threading.Thread.Sleep(500);

            Process clear = new Process();
            clear.StartInfo.UseShellExecute = false;
            clear.StartInfo.FileName = @"C:\Program Files (x86)\Evolve\Data\CStandbyList.exe";
            clear.Start();

            /*Process logoff = new Process();
            logoff.StartInfo.UseShellExecute = false;
            logoff.StartInfo.FileName = @"C:\Program Files (x86)\Evolve\Data\logoff.exe";
            logoff.Start();*/
        }

        internal static void DisableAutomaticUpdates()
        {
            //Temporary disabled DeliveryOptimization! By default removed in EvolveOS.

            //EvolveUtilities.TryDeleteRegistryValue(false, @"Software\Microsoft\Windows\CurrentVersion\DeliveryOptimization", "SystemSettingsDownloadMode");
            EvolveUtilities.TryDeleteRegistryValue(true, @"SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "UxOption");
            EvolveUtilities.TryDeleteRegistryValue(true, @"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "AUOptions");
            EvolveUtilities.TryDeleteRegistryValue(true, @"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoUpdate");
            EvolveUtilities.TryDeleteRegistryValue(true, @"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoRebootWithLoggedOnUsers");
            //EvolveUtilities.TryDeleteRegistryValue(true, @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Config", "DODownloadMode");
            EvolveUtilities.TryDeleteRegistryValue(true, @"SOFTWARE\Policies\Microsoft\Speech", "AllowSpeechModelUpdate");
            //Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DoSvc", "Start", "3", RegistryValueKind.DWord);
            //Utilities.StartService("DoSvc");

            // enable the silent app installation (Store app install/update is broken otherwise!)
            //Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\Maintenance", "MaintenanceDisabled", "0", RegistryValueKind.DWord);
            EvolveUtilities.TryDeleteRegistryValue(true, @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\Maintenance", "MaintenanceDisabled");
        }

        internal static void EnableAutomaticUpdates()
        {
            //Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\DeliveryOptimization", "SystemSettingsDownloadMode", "3", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_USERS\S-1-5-20\Software\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Settings", "DownloadMode", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "UxOption", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoUpdate", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "AUOptions", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoRebootWithLoggedOnUsers", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Config", "DODownloadMode", "0", RegistryValueKind.DWord);
            //Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DoSvc", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Speech", "AllowSpeechModelUpdate", 0);

            //Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\Maintenance", "MaintenanceDisabled", "1", RegistryValueKind.DWord);

            //Utilities.StopService("DoSvc");
        }

        internal static void DisableDriverUpdates()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "ExcludeWUDriversInQualityUpdate", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "ExcludeWUDriversInQualityUpdate", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Update\ExcludeWUDriversInQualityUpdate", "value", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Update", "ExcludeWUDriversInQualityUpdate", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\current\device\Update", "ExcludeWUDriversInQualityUpdate", "1", RegistryValueKind.DWord);
        }

        internal static void EnableDriverUpdates()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "ExcludeWUDriversInQualityUpdate", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "ExcludeWUDriversInQualityUpdate", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Update\ExcludeWUDriversInQualityUpdate", "value", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Update", "ExcludeWUDriversInQualityUpdate", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\current\device\Update", "ExcludeWUDriversInQualityUpdate", "0", RegistryValueKind.DWord);
        }

        internal static void DisableInsiderService()
        {
            EvolveUtilities.StopService("wisvc");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\wisvc", "Start", "4", RegistryValueKind.DWord);
        }

        internal static void EnableInsiderService()
        {
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\wisvc", "Start", "3", RegistryValueKind.DWord);
            EvolveUtilities.StartService("wisvc");
        }

        internal static void DisableStoreUpdates()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SilentInstalledAppsEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CloudContent", "DisableSoftLanding", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "PreInstalledAppsEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CloudContent", "DisableWindowsConsumerFeatures", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "OemPreInstalledAppsEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\WindowsStore", "AutoDownload", "2", RegistryValueKind.DWord);
        }

        internal static void EnableStoreUpdates()
        {
            EvolveUtilities.TryDeleteRegistryValue(false, @"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SilentInstalledAppsEnabled");
            EvolveUtilities.TryDeleteRegistryValue(true, @"SOFTWARE\Policies\Microsoft\Windows\CloudContent", "DisableSoftLanding");
            EvolveUtilities.TryDeleteRegistryValue(false, @"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "PreInstalledAppsEnabled");
            EvolveUtilities.TryDeleteRegistryValue(true, @"SOFTWARE\Policies\Microsoft\Windows\CloudContent", "DisableWindowsConsumerFeatures");
            EvolveUtilities.TryDeleteRegistryValue(false, @"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "OemPreInstalledAppsEnabled");
            EvolveUtilities.TryDeleteRegistryValue(true, @"SOFTWARE\Policies\Microsoft\WindowsStore", "AutoDownload");
        }
    }
}
