@echo off
setlocal enabledelayedexpansion

:: Go to project root (folder where batch file is placed)
cd /d "%~dp0"

:: Set the root folder containing archived allure-results
set "archivedRoot=Allure-Reports"

:: Initialize latestFolder variable
set "latestFolder="

:: Find the latest timestamped Report_ folder (sorted by date descending)
for /f "delims=" %%i in ('dir "%archivedRoot%\Report_*" /b /ad /o-d') do (
    set "latestFolder=%%i"
    goto :found
)

:found
if not defined latestFolder (
    echo No Report_ folders found in %archivedRoot%.
    pause
    exit /b
)

set "source=%archivedRoot%\%latestFolder%"
set "output=Allure-HTML-Report"

:: Generate Allure report using --single-file
echo Generating single-file Allure report from: %source%
allure generate --single-file "%source%" --clean -o "%output%"

:: Open the single-file report (usually named index.html)
if exist "%output%\index.html" (
    echo Report generated. Opening in browser...
    start "" "%output%\index.html"
) else (
    echo Report generation failed. index.html not found in %output%.
)

endlocal
pause
