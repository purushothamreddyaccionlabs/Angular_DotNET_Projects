$sourceFolder = "D:\a\1\s\ScriptsPS"   # Replace with the path to the source folder B
$destFolder = "D:\a\1\s\dist\eshop-app"     # Replace with the path to the destination folder A
$fileName = "web.config"   # Replace with the name of the file you want to move

# Check if the source file exists
if (Test-Path "$sourceFolder\$fileName") {
    # Move the file to the destination folder
    Move-Item "$sourceFolder\$fileName" "$destFolder\$fileName" -Force
    Write-Output "File $fileName moved successfully from $sourceFolder to $destFolder"
} else {
    Write-Output "File $fileName not found in $sourceFolder"
}
