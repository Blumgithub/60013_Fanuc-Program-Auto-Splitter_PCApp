# Blum Version 1.0

## 11/12/2024 BB
- BAT file replaced with Windows Program
- Target TEXT file can have any name, but must be a .txt file and in Fanuc program format
- Start by double clicking on "Fanuc-Program-Auto-Splitter.exe"

# Blum Version 0.9

## 11/05/2024 BB
- Initial release of Blum Version
- Added Batch file for configuring target path and file
- Updated .csproj file for configuring output directory

## Procedure
Note: Fanuc program backup file can be any name, but contents must be in the standard Fanuc program format.

1. Run "FANUC_Program_Auto_Splitter.bat"

2. When Prompted enter the complete path of where the Fanuc program backup is located and press enter
    ### Example: C:\Robodrill\Backup

3. When Prompted enter the the filename of the Fanuc program backup excluding the extension and pressing enter
    ### Example: ALL-FLDR

4. If sucessfully completed a folder will be created at the path specified containing each of the programs from the Fanuc backup

;***************Original Description***************************
# Split-FANUC-Program-Backup

When you run a backup of a FANUC CNC control it makes a file named `ALL-PROG.TXT` that contains all CNC programs in the control memory. 

This program splits a FANUC `ALL-PROG.TXT` program backup file in to individual files.

## Usage
At least one argument is required. Enter the full path of the file you would like to split.

### EXAMPLE

    Split-FANUC-Program-Backup.exe "C:\temp\ALL-PROG.TXT"
    
## Output
It will make a subfolder in the same location as the text file you passed in. This folder will be named like the file. e.g. `C:\temp\ALL-PROG\`.
All of the CNC programs found in the backup will be placed in this folder.
