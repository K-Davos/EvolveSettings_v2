using Microsoft.Win32;
using System;
using System.IO;

namespace EvolveSettings
{
    internal static class CoreHelper
    {
        internal readonly static string CoreFolder = CleanHelper.ProgramFiles + "\\Evolve\\";
        internal readonly static string DataFolder = CleanHelper.ProgramFiles + "\\Evolve\\Data\\";
        internal readonly static string Data2Folder = CleanHelper.ProgramData + "\\Evolve\\Data\\";
        internal readonly static string ScriptsFolder = CleanHelper.ProgramFiles + "\\Evolve\\Scripts\\";

        readonly static string[] DataItems =
        {
        };

        readonly static string[] DataFiles =
        {
        };

        readonly static string[] scriptItems =
        {
        };

        readonly static string[] scriptFiles =
        {
        };

        internal static void Deploy()
        {
            if (!Directory.Exists(CoreFolder))
            {
                Directory.CreateDirectory(CoreFolder);
            }
            if (!Directory.Exists(DataFolder))
            {
                Directory.CreateDirectory(DataFolder);
            }
            if (!Directory.Exists(ScriptsFolder))
            {
                Directory.CreateDirectory(ScriptsFolder);
            }
            if (!Directory.Exists(Data2Folder))
            {
                Directory.CreateDirectory(Data2Folder);
            }
            for (int i = 0; i < DataItems.Length; i++)
            {
                if (!File.Exists(DataItems[i])) File.WriteAllText(DataItems[i], DataFiles[i]);
            }
        }

        internal static void RegisterEvolveSettings()
        {
            try
            {
                using (RegistryKey k = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Evolve\\EvolveSettings", true))
                {
                    k.SetValue("EvolveSettings", 1);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("CoreHelper.RegisterEvolveSettings", ex.Message, ex.StackTrace);
            }
        }
    }
}