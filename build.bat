@echo off
setlocal

echo.
echo ========================================
echo   Building dll
echo ========================================
echo.

if exist output rmdir /s /q output
mkdir output

dotnet\dotnet.exe build MyAddin.csproj -c Release

if errorlevel 1 (
    echo.
    echo ========================================
    echo   BUILD FAILED
    echo ========================================
    pause
    exit /b 1
)

copy /Y "bin\Release\net10.0-windows\MyAddin.dll" "output\MyAddin.dll" >nul

echo.
echo ========================================
echo   BUILD SUCCESSFUL
echo ========================================
echo.
echo DLL:
echo   output\MyAddin.dll
echo.

pause