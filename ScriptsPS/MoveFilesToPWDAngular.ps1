$sourceDirectory = "D:\a\1\s\Angular_DotNET_Projects\Angular_Projects\EshopApp"
$defaultDirectory = "D:\a\1\s"
$folderToDelete = "D:\a\1\s\Angular_DotNET_Projects"

Get-ChildItem -Path $sourceDirectory -Recurse -Force | 
ForEach-Object {
    if($_.PSIsContainer) {
        # Move folders to default directory
        Move-Item $_.FullName -Destination $defaultDirectory
    }
    else {
        # Move files to default directory
        Move-Item $_.FullName -Destination $defaultDirectory
    }
}

# Delete specified folder
Remove-Item $folderToDelete -Recurse -Force