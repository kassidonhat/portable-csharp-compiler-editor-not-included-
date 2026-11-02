@echo off
setlocal EnableDelayedExpansion


set "mainFolder=%~dp0"
set "mainFolder=%mainFolder:\bat Files\=%"
cd /d "%mainFolder%"
echo "%mainFolder%"

setlocal




set "InputHere=n"



@REM  for %%f in ("src/"*) do (
for /D %%f in ("src/"*) do (

    IF not "!InputHere!" == "y" (
        echo %%f
        set /p "InputHere=Do you want to build %%f(y/n): "

        IF "!InputHere!" == "y" (


            @REM  set "NAMEEntered=%%f"
            @REM  set "NAMEEntered=!NAMEEntered:.cs=!"
            set "ProjectToBuild=%%f"
            @REM  set "ProjectToBuild=!NAMEEntered:.cs=!"


        ) ELSE (
            echo.

        )
    ) ELSE (
        echo.

    )
)


for %%f in ("src/%ProjectToBuild%/"*) do (
    set "FirstHolderString=%%f"
    set "secondHolderString=!FirstHolderString:.csproj=!"

    IF not "!FirstHolderString!" == "!secondHolderString!" (

        set "csprojUsed=!FirstHolderString!"
        set "csprojUsedNoFileExtension=!secondHolderString!"



    ) ELSE (
            echo.

    )


)




echo choosen file: %csprojUsed%


@REM  pause


IF not "%csprojUsed%" == "" (



    echo.
    echo ========================================
    echo   Building Inventor 2027 Add-in
    echo ========================================
    echo.



    if not exist "output" mkdir "output"


    dotnet\dotnet.exe build "src/%ProjectToBuild%/%csprojUsed%" -c Release 
    @REM  /p:NAMEEnteredPassed="%NAMEEntered%"

    if errorlevel 1 (
        echo.
        echo ========================================
        echo   BUILD FAILED
        echo ========================================
        pause
        exit /b 1
    )



    copy /Y "src\%ProjectToBuild%\bin\Release\net10.0-windows\%csprojUsedNoFileExtension%.dll" "output\%csprojUsedNoFileExtension%.dll" >nul

    echo.
    echo ========================================
    echo   BUILD SUCCESSFUL
    echo ========================================
    echo.
    echo DLL:
    echo   output\%csprojUsedNoFileExtension%.dll
    echo.



    echo.
    echo ========================================
    echo   COPY FILES TO AddinsFolder
    echo ========================================
    echo.

    xcopy "X:\Desktop\model stuf\AutoDeskDevelopment\InventorComplier\addinfiles" "C:\Users\khatfield\AppData\Roaming\Autodesk\Inventor 2027\Addins\addInCustom" /Y
    xcopy "X:\Desktop\model stuf\AutoDeskDevelopment\InventorComplier\output" "C:\Users\khatfield\AppData\Roaming\Autodesk\Inventor 2027\Addins\addInCustom\DLLs" /Y


    echo.
    echo ========================================
    echo   COPY FILES TO AddinsFolder SUCCESSFUL
    echo ========================================
    echo.






) ELSE (
            echo.

)


IF "%csprojUsed%" == "" (
    echo.
    echo ========================================
    echo   no file choosen
    echo ========================================
    echo.
) ELSE (
            echo.

)



echo.
echo ========================================
echo   RUN Inventor
echo ========================================
echo.


@REM  set "InputRunInventor=n"
@REM  set /p "InputRunInventor=Do you want Run Inventor (y/n): "
@REM  echo %InputRunInventor%
start "" "C:\Program Files\Autodesk\Inventor 2027\Bin\Inventor.exe"

