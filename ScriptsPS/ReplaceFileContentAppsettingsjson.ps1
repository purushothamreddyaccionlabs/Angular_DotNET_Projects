# Get the content of file B
$BContent = Get-Content -Path "D:\a\1\s\appsettingsjson.txt" -Raw

# Set the content of file A to be the same as file B
Set-Content -Path "D:\a\1\s\EshopApplication\appsettings.json" -Value $BContent
