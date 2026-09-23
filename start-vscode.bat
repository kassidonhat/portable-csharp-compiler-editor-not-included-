@echo off
setlocal

set "DOTNET_ROOT=%~dp0dotnet"
set "PATH=%DOTNET_ROOT%;%PATH%"

echo Using portable .NET:
"%DOTNET_ROOT%\dotnet.exe" --version

echo.
echo Starting VS Code...

code "%~dp0"

endlocal