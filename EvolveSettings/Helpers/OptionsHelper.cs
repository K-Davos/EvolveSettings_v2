using EvolveSettings.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace EvolveSettings
{
    internal static class OptionsHelper
    {
        internal readonly static string SettingsFile = CoreHelper.Data2Folder + "\\EvolveSettings.json";

        internal static Models.Options CurrentOptions = new Models.Options();
        internal static void SaveSettings()
        {
            if (File.Exists(SettingsFile))
            {
                string jsonFile = File.ReadAllText(SettingsFile);
                string jsonMemory = JsonConvert.SerializeObject(CurrentOptions);

                // check to see if no changes have been made
                if (JToken.DeepEquals(JObject.Parse(jsonFile), JObject.Parse(jsonMemory))) return;

                File.Delete(SettingsFile);

                using (FileStream fs = File.Open(SettingsFile, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(fs))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;

                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jw, CurrentOptions);
                }
            }
        }
        internal static void LoadSettings()
        {
            if (!File.Exists(SettingsFile) || File.ReadAllText(SettingsFile).Contains("\"Evolve\":"))
            {
                // DEFAULT OPTIONS
                CurrentOptions.CurrentUser = string.Empty;
                CurrentOptions.UserName = string.Empty;
                CurrentOptions.AutoStart = false;
                CurrentOptions.WinTheme = true;
                CurrentOptions.SignUp = false;
                CurrentOptions.CustomDNS = false;
                CurrentOptions.SystemMonitor = false;
                CurrentOptions.PowerSavingsMode = false;
                CurrentOptions.GameMode = false;
                CurrentOptions.WindowsAutoUpdates = false;
                CurrentOptions.ExcludeWinDriverUpdates = false;
                CurrentOptions.InsiderService = false;
                CurrentOptions.MsStoreUpdates = false;
                CurrentOptions.BlurEffect = false;
                CurrentOptions.TelemetryServices = false;
                CurrentOptions.TelemetryTasks = false;
                CurrentOptions.EnhancePrivacy = false;
                CurrentOptions.EdgeTelemetry = false;
                CurrentOptions.EdgeDiscover = false;
                CurrentOptions.ChromeTelemetry = false;
                CurrentOptions.StartMenuAds = false;
                CurrentOptions.Cortana = false;
                CurrentOptions.HomeGroup = false;
                CurrentOptions.NvidiaTelemetry = false;
                CurrentOptions.MsOfficeTelemetry = false;

                using (FileStream fs = File.Open(SettingsFile, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(fs))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;

                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jw, CurrentOptions);
                }
            }
            else
            {
                CurrentOptions = JsonConvert.DeserializeObject<Options>(File.ReadAllText(SettingsFile));
            }
        }
    }
}