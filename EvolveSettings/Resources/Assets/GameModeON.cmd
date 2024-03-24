@echo off

:: Ending tasks.
taskkill /im "iCue.exe" /f
taskkill /im "ArmouryCrate.exe" /f
taskkill /im "AcPowerNotification.exe" /f
taskkill /im "NoiseCancelingEngine.exe" /f
taskkill /im "ArmourySocketServer.exe" /f
taskkill /im "GoogleCrashHandler.exe" /f
taskkill /im "GoogleCrashHandler64.exe" /f

:: Attempting to stop services.
sc stop "asus"
sc stop "asusm"
sc stop "AsusUpdateCheck"
sc stop "LightingService"
sc stop "ArmouryCrateService"
sc stop "AsusCertService"
sc stop "asComSvc"
sc stop "CorsairCpuIdService"
sc stop "CorsairService"
sc stop "iCUEUpdateService"
sc stop "ROG Live Service"
sc stop "EventSystem"
sc stop "SENS"
sc stop "WpnUserService_69ec3"
sc stop "LanmanServer"
sc stop "ClickToRunSvc"

sc stop "InstallService"
sc stop "DsmSvc"
sc stop "NcbService"
sc stop "UsoSvc"
sc stop "RmSvc"

sc stop "WpnService"
sc stop "WpnUserService_143a1211"
sc stop "WdiServiceHost"
sc stop "EventSystem"

:: Disable services.
sc config "asus" start=disabled
sc config "asusm" start=disabled
sc config "AsusUpdateCheck" start=disabled
sc config "LightingService" start=disabled
sc config "ArmouryCrateService" start=disabled
sc config "AsusCertService" start=disabled
sc config "asComSvc" start=disabled
sc config "CorsairCpuIdService" start=disabled
sc config "CorsairLLAService" start=disabled
sc config "CorsairService" start=disabled
sc config "iCUEUpdateService" start=disabled
sc config "ROG Live Service" start=disabled
sc config "EventSystem" start=disabled
sc config "SENS" start=disabled
sc config "WpnUserService_69ec3" start=disabled
sc config "LanmanServer" start=disabled
sc config "ClickToRunSvc" start=disabled

sc config "InstallService" start=disabled
sc config "DsmSvc" start=disabled
sc config "NcbService" start=disabled
sc config "UsoSvc" start=disabled
sc config "RmSvc" start=disabled

sc config "WpnService" start=disabled
sc config "WpnUserService_143a1211" start=disabled
sc config "WdiServiceHost" start=disabled
sc config "EventSystem" start=disabled

sc config spooler start= disabled
net stop spooler
net stop printnotify

:: Disable Tasks.
schtasks /End /TN "\ASUS\AcPowerNotification"
schtasks /End /TN "\ASUS\ArmourySocketServer"
schtasks /End /TN "\ASUS\Framework Service"
schtasks /End /TN "\ASUS\NoiseCancelingEngine"
schtasks /End /TN "\ASUS\P508PowerAgent_sdk"
schtasks /Change /TN "\ASUS\AcPowerNotification" /Disable
schtasks /Change /TN "\ASUS\ArmourySocketServer" /Disable
schtasks /Change /TN "\ASUS\Framework Service" /Disable
schtasks /Change /TN "\ASUS\NoiseCancelingEngine" /Disable
schtasks /Change /TN "\ASUS\P508PowerAgent_sdk" /Disable

:: Clear temporary folder (Temp - %Temp% - Prefetch).
del /s /q C:\Windows\Temp\*.*
del /s /q C:\Users\Admin\AppData\Local\Temp\*.*
del /s /q C:\Windows\Prefetch\*.*
rmdir /s /q C:\Windows\Temp\
rmdir /s /q C:\Users\Admin\AppData\Local\Temp\
rmdir /s /q C:\Windows\Prefetch\

:: Turn off startup apps.
reg delete "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v "Corsair iCUE5 Software" /f

mkdir C:\Windows\Temp\EvolveX-GamingMode
mkdir C:\Windows\Temp\EvolveX-GamingMode\Startup
move "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup\*" C:\Windows\Temp\EvolveX-GamingMode\Startup\
move "C:\Program Files (x86)\Google\Update\1.3.36.352\GoogleCrashHandler.exe" C:\Windows\Temp\EvolveX-GamingMode\
move "C:\Program Files (x86)\Google\Update\1.3.36.352\GoogleCrashHandler64.exe" C:\Windows\Temp\EvolveX-GamingMode\
exit 0