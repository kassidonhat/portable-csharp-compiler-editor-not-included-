@echo off
setlocal

set /p "NAMEEntered=Enter add-in name: "


echo.
echo ========================================
echo   Building Inventor 2027 Add-in
echo ========================================
echo.

if exist output rmdir /s /q output
mkdir output

dotnet\dotnet.exe build ProjectFile.csproj -c Release /p:NAMEEnteredPassed="%NAMEEntered%"

if errorlevel 1 (
    echo.
    echo ========================================
    echo   BUILD FAILED
    echo ========================================
    pause
    exit /b 1
)

copy /Y "bin\Release\net10.0-windows\%NAMEEntered%.dll" "output\%NAMEEntered%.dll" >nul

echo.
echo ========================================
echo   BUILD SUCCESSFUL
echo ========================================
echo.
echo DLL:
echo   output\%NAMEEntered%.dll
echo.

pause


@REM  asdf
