﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EvolveSettings.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EvolveSettings.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap add {
            get {
                object obj = ResourceManager.GetObject("add", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap chat {
            get {
                object obj = ResourceManager.GetObject("chat", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap checkmark_invalid {
            get {
                object obj = ResourceManager.GetObject("checkmark_invalid", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap checkmark_valid {
            get {
                object obj = ResourceManager.GetObject("checkmark_valid", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap delete {
            get {
                object obj = ResourceManager.GetObject("delete", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap edit {
            get {
                object obj = ResourceManager.GetObject("edit", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap encrypted_file {
            get {
                object obj = ResourceManager.GetObject("encrypted_file", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap encryptor {
            get {
                object obj = ResourceManager.GetObject("encryptor", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap error {
            get {
                object obj = ResourceManager.GetObject("error", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap evolve_settings {
            get {
                object obj = ResourceManager.GetObject("evolve_settings", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @echo off
        ///powercfg /import &quot;C:\Program Files(x86)\Evolve\Data\EvolveX-Performance.pow 9183f4e0-8bdc-47d1-8112-20d0095879ee&quot;
        ///exit 0.
        /// </summary>
        internal static string EvolvePerformance {
            get {
                return ResourceManager.GetString("EvolvePerformance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @echo off
        ///powercfg /import &quot;C:\Program Files (x86)\Evolve\Data\EvolveX-Performance.pow a1841308-3541-4fab-bc81-f71556f20b4a&quot;
        ///exit 0.
        /// </summary>
        internal static string EvolvePowerSaving {
            get {
                return ResourceManager.GetString("EvolvePowerSaving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap exclamation {
            get {
                object obj = ResourceManager.GetObject("exclamation", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @echo off
        ///
        ///:: Set services back to default and start the services.
        ///sc config &quot;asus&quot; start=auto
        ///sc config &quot;asusm&quot; start=demand
        ///sc config &quot;AsusUpdateCheck&quot; start=auto
        ///sc config &quot;LightingService&quot; start=auto
        ///sc config &quot;ArmouryCrateService&quot; start=auto
        ///sc config &quot;AsusCertService&quot; start=auto
        ///sc config &quot;asComSvc&quot; start=auto
        ///sc config &quot;CorsairCpuIdService&quot; start=auto
        ///sc config &quot;CorsairCpuIdService&quot; start=auto
        ///sc config &quot;CorsairService&quot; start=auto
        ///sc config &quot;iCUEUpdateService&quot; start=demand
        ///sc config &quot;RO [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GameModeOFF {
            get {
                return ResourceManager.GetString("GameModeOFF", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @echo off
        ///
        ///:: Ending tasks.
        ///taskkill /im &quot;iCue.exe&quot; /f
        ///taskkill /im &quot;ArmouryCrate.exe&quot; /f
        ///taskkill /im &quot;AcPowerNotification.exe&quot; /f
        ///taskkill /im &quot;NoiseCancelingEngine.exe&quot; /f
        ///taskkill /im &quot;ArmourySocketServer.exe&quot; /f
        ///taskkill /im &quot;GoogleCrashHandler.exe&quot; /f
        ///taskkill /im &quot;GoogleCrashHandler64.exe&quot; /f
        ///
        ///:: Attempting to stop services.
        ///sc stop &quot;asus&quot;
        ///sc stop &quot;asusm&quot;
        ///sc stop &quot;AsusUpdateCheck&quot;
        ///sc stop &quot;LightingService&quot;
        ///sc stop &quot;ArmouryCrateService&quot;
        ///sc stop &quot;AsusCertService&quot;
        ///sc stop &quot;asComSvc&quot;
        ///s [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GameModeON {
            get {
                return ResourceManager.GetString("GameModeON", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap home {
            get {
                object obj = ResourceManager.GetObject("home", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap information {
            get {
                object obj = ResourceManager.GetObject("information", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap logout {
            get {
                object obj = ResourceManager.GetObject("logout", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap maintenance {
            get {
                object obj = ResourceManager.GetObject("maintenance", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap maximize {
            get {
                object obj = ResourceManager.GetObject("maximize", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap maximize_black {
            get {
                object obj = ResourceManager.GetObject("maximize_black", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap menu {
            get {
                object obj = ResourceManager.GetObject("menu", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap minimize {
            get {
                object obj = ResourceManager.GetObject("minimize", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap minimize_black {
            get {
                object obj = ResourceManager.GetObject("minimize_black", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap network {
            get {
                object obj = ResourceManager.GetObject("network", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap pwmanager {
            get {
                object obj = ResourceManager.GetObject("pwmanager", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap question {
            get {
                object obj = ResourceManager.GetObject("question", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap quit {
            get {
                object obj = ResourceManager.GetObject("quit", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap quit_black {
            get {
                object obj = ResourceManager.GetObject("quit_black", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap settings {
            get {
                object obj = ResourceManager.GetObject("settings", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap shutdown {
            get {
                object obj = ResourceManager.GetObject("shutdown", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap sys_monitor {
            get {
                object obj = ResourceManager.GetObject("sys_monitor", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap user {
            get {
                object obj = ResourceManager.GetObject("user", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap usersm {
            get {
                object obj = ResourceManager.GetObject("usersm", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap win11tweaks {
            get {
                object obj = ResourceManager.GetObject("win11tweaks", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
