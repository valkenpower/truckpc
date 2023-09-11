@echo off
cd /d "%userprofile%\Documents\truckpc"  
git pull


if errorlevel 0 (
    set "setupPath=%userprofile%\Documents\truckpc\app\setup.exe"
    
    if exist "%setupPath%" (
        REM Run the setup.exe file
        start "" "%setupPath%"
    ) else (
        echo Setup.exe and "%userprofile%\Documents\truckpc\app\setup.exe" not found.
    )
) else (
    echo Git pull operation failed.
)


pause