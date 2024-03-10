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