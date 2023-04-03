# Get the content of file b
$BContent = Get-Content -Path "D:\a\1\s\ScriptsPS\ReplaceProgramcs.txt" -Raw

# Set the content of file A to be the same as program cs
Set-Content -Path "D:\a\1\s\EshopApplication\Program.cs" -Value $BContent
