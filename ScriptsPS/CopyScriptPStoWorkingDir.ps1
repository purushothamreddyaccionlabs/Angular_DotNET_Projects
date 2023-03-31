# Set the source and destination folders
$sourceFolder = "D:\a\1\s\Angular_DotNET_Projects\ScriptsPS"
$destinationFolder = "D:\a\1\s"

# Check if the source folder exists
if (Test-Path $sourceFolder) {
    # Move the folder to the destination folder
    Move-Item $sourceFolder $destinationFolder
    Write-Host "Folder moved successfully."
}
else {
    Write-Host "The source folder does not exist."
}
