using System;

namespace EvolveSettings.Models
{
    [Serializable]
    public sealed class Options
    {
        public string CurrentUser { get; set; }
        public string UserName { get; set; }
        public bool AutoStart { get; set; }
        public bool WinTheme { get; set; }
        public bool SignUp { get; set; }
        public bool CustomDNS { get; set; }
        public bool SystemMonitor { get; set; }
        public bool PowerSavingsMode { get; set; }
        public bool GameMode { get; set; }
        public bool WindowsAutoUpdates { get; set; }
        public bool ExcludeWinDriverUpdates { get; set; }
        public bool InsiderService { get; set; }
        public bool MsStoreUpdates { get; set; }
    }
    public class GenerateConfig
    {
        public bool IsLowerCase { get; set; }
        public bool IsUpperCase { get; set; }
        public bool IsDigits { get; set; }
        public bool IsSymbols { get; set; }
        public int Length { get; set; }
    }
}
