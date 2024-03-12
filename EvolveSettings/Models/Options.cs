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
