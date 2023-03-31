# Set the paths for the source and destination files
$sourceFilePath = "D:\a\1\a\connection--String--Sql--backend.txt"
$destinationFilePath = "D:\a\1\s\EshopApplication\appsettings.json"

# Read the contents of the source file
$sourceContent = Get-Content $sourceFilePath -Raw

# Read the contents of the destination file
$destinationContent = Get-Content $destinationFilePath -Raw

# Check if the destination content contains the connection string placeholder
if ($destinationContent.Contains("#<connection--String--Sql--backend>#")) {

    # Replace the connection string placeholder with the source content
    $newContent = $destinationContent.Replace("#<connection--String--Sql--backend>#", $sourceContent)

    # Write the new content to the destination file
    Set-Content $destinationFilePath -Value $newContent

    Write-Host "Replaced connection string placeholder in destination file with contents of source file."

} else {

    Write-Host "Destination file does not contain connection string placeholder."
}

Get-Content D:\a\1\s\EshopApplication\appsettings.json
