﻿using EvolveSettings.Helpers;
using EvolveSettings.Forms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace EvolveSettings
{
    static class Program
    {
        public static bool KeepRunning { get; set; }

        internal readonly static float Major = 1;
        internal readonly static float Minor = 0;
        internal readonly static bool EXPERIMENTAL_BUILD = false;

        internal static string GetCurrentVersionTostring()
        {
            return $"{Major.ToString()}.{Minor.ToString()}";
        }

        internal static float GetCurrentVersionToFloat()
        {
            return float.Parse(GetCurrentVersionTostring());
        }
        internal static bool SILENT_MODE = false;
        internal static bool UNSAFE_MODE = false;

        const string _jsonAssembly = @"EvolveSettings.Newtonsoft.Json.dll";

        const string MUTEX_GUID = "{EVOLVE-66EE744A-FF65-40BC-985B-1EF2234027E4-EVOLVE}";
        internal static Mutex MUTEX;

        static bool _notRunning;
        static string _alreadyRunning = "EvolveSettings already running in the background!";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            EmbeddedAssembly.Load(_jsonAssembly, _jsonAssembly.Replace("EvolveSettings.", string.Empty));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // single-instance mechanism
            MUTEX = new Mutex(true, MUTEX_GUID, out _notRunning);

            SILENT_MODE = true;
            CoreHelper.Deploy();
            CoreHelper.RegisterEvolveSettings();
            OptionsHelper.LoadSettings();
            //Application.Run(new SplashForm());

            if (!_notRunning)
            {
                MessageBox.Show(_alreadyRunning, "EvolveSettings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
                return;
            }

            KeepRunning = true;
            while (KeepRunning)
            {
                KeepRunning = false;
                Application.Run(new SplashForm());
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception error = (Exception)e.ExceptionObject;
            Logger.LogError("Program.Main-UnhandledException", error.Message, error.StackTrace);
        }
        private static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }
}
