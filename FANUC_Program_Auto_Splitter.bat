@echo off
set /p InputPath="Enter the Input file path: "
set /p InputFile="Enter the input file name: "
start Split-FANUC-Program-Backup.exe "%InputPath%\%InputFile%.txt"
pause
