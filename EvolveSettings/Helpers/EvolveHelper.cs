using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
    }
}
