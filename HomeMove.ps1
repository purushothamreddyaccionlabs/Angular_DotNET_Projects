# Define the paths for folders A and C
$folderA = "D:\a\1\s\Angular_DotNET_Projects"
$folderB = "D:\a\1\s"

# Create folder A inside folder B
New-Item -ItemType Directory -Path $folderA

# Move all files and folders from folder B to folder A
Get-ChildItem $folderB | Move-Item -Destination $folderA
