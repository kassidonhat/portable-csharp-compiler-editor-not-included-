@echo off


setlocal


set "DOTNET_ROOT=%~dp0\dotnet"
set "DOTNET_ROOT=%DOTNET_ROOT:\bat Files\=%"
set "PATH=%DOTNET_ROOT%;%PATH%"
echo "%DOTNET_ROOT%"

echo Using portable .NET:
"%DOTNET_ROOT%\dotnet.exe" --version

echo.
echo Starting VS Code...

code "%~dp0.."

endlocal