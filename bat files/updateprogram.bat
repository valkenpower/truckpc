@echo off
cd /d "%userprofile%\Documents\truckpc"  
git pull
set "setupPath=%userprofile%\Documents\truckpc\app"
set "setupPath2=%userprofile%\Documents\truckpc\app\setup"
if errorlevel 0 (
    if exist "%setupPath%" (
        REM Run the setup.exe file
        start "" "%setupPath2%"
    ) else (
        echo Setup.exe and %setupPath% not found.
    )
) else (
    echo Git pull operation failed.
)


