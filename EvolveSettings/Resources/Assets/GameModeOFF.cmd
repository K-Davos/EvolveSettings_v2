@echo off

:: Set services back to default and start the services.
sc config "asus" start=auto
sc config "asusm" start=demand
sc config "AsusUpdateCheck" start=auto
sc config "LightingService" start=auto
sc config "ArmouryCrateService" start=auto
sc config "AsusCertService" start=auto
sc config "asComSvc" start=auto
sc config "CorsairCpuIdService" start=auto
sc config "CorsairCpuIdService" start=auto
sc config "CorsairService" start=auto
sc config "iCUEUpdateService" start=demand
sc config "ROG Live Service" start=auto
sc config "EventSystem" start=auto
sc config "SENS" start=auto
sc config "WpnUserService_69ec3" start=auto
sc config "LanmanServer" start=demand
sc config "ClickToRunSvc" start=auto

sc config "InstallService" start=demand
sc config "DsmSvc" start=demand
sc config "NcbService" start=demand
sc config "UsoSvc" start=demand
sc config "RmSvc" start=demand

sc config "WpnService" start=auto
sc config "WpnUserService_143a1211" start=auto
sc config "WdiServiceHost" start=demand
sc config "EventSystem" start=disabled

sc start "asus"
sc start "AsusUpdateCheck"
sc start "LightingService"
sc start "ArmouryCrateService"
sc start "AsusCertService"
sc start "asComSvc"
sc start "CorsairCpuIdService"
sc start "CorsairService"
sc start "ROG Live Service"
sc start "EventSystem"
sc start "SENS"
sc start "WpnUserService_69ec3"
sc start "ClickToRunSvc"

sc start "InstallService"
sc start "DsmSvc"
sc start "NcbService"
sc start "UsoSvc"
sc start "RmSvc"

sc start "WpnService"
sc start "WpnUserService_143a1211"
sc start "WdiServiceHost"
sc start "EventSystem"

sc config spooler start= auto
net start spooler

:: Enable Tasks.
schtasks /Change /TN "\ASUS\AcPowerNotification" /Enable
schtasks /Change /TN "\ASUS\ArmourySocketServer" /Enable
schtasks /Change /TN "\ASUS\Framework Service" /Enable
schtasks /Change /TN "\ASUS\NoiseCancelingEngine" /Enable
schtasks /Change /TN "\ASUS\P508PowerAgent_sdk" /Enable

:: Restore startup apps.
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /f /v "Corsair iCUE5 Software" /t REG_SZ /d "D:\Program Files\Corsair iCUE5 Software\iCUE Launcher.exe --autorun"

move "C:\Windows\Temp\EvolveX-GamingMode\Startup\*" "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup\"
move "C:\Windows\Temp\EvolveX-GamingMode\GoogleCrashHandler.exe" "C:\Program Files (x86)\Google\Update\1.3.36.352\"
move "C:\Windows\Temp\EvolveX-GamingMode\GoogleCrashHandler64.exe" "C:\Program Files (x86)\Google\Update\1.3.36.352\"
rmdir C:\Windows\Temp\EvolveX-GamingMode
rmdir C:\Windows\Temp\EvolveX-GamingMode\Startup
exit 0