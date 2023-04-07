$AZUREPAT = $env:AZUREPAT
$AZUSERNAME = "anything"
$AZUSER_EMAIL = "nageshdevops77@outlook.com"
$AZORG = "Learning-Devops-7777"

git config --system core.longpaths true

# Clone the repository and remove its Git historyyyy
git clone https://github.com/purushothamreddyaccionlabs/Angular_DotNET_Projects.git

cd Angular_DotNET_Projects
Remove-Item -Recurse -Force .git

cd ..

# Clone the repository again, this time with Azure credentials
$GIT_CMD_REPOSITORY="https://$AZUREPAT@dev.azure.com/Learning-Devops-7777/Abdul/_git/syncgitEshopCommerce"
git clone $GIT_CMD_REPOSITORY

$folder1 = "D:\a\Angular_DotNET_Projects\Angular_DotNET_Projects\Angular_DotNET_Projects"
$folder2 = "D:\a\Angular_DotNET_Projects\Angular_DotNET_Projects\syncgitEshopCommerce"

# Get a list of files and folders in each folder
$folder1Items = Get-ChildItem $folder1 -Recurse
$folder2Items = Get-ChildItem $folder2 -Recurse

# Compare the two lists and find unique items
$uniqueInFolder1 = Compare-Object $folder1Items $folder2Items -Property Name, Length -PassThru | Where-Object { $_.SideIndicator -eq '<=' }
$uniqueInFolder2 = Compare-Object $folder1Items $folder2Items -Property Name, Length -PassThru | Where-Object { $_.SideIndicator -eq '=>' }

# Display the unique files or folders in each folder
Write-Host "Unique files or folders in " + $folder1 + ":"


$uniqueInFolder1 | ForEach-Object { Write-Host $_.FullName }

Write-Host "Unique files or folders in " + $folder2 + ":"
$uniqueInFolder2 | ForEach-Object { Write-Host $_.FullName }

$uniqueInFolder2 | ForEach-Object { Remove-Item $_.FullName -Force }

# Copy the contents of the local repository to the cloned Azure repository
Copy-Item -Recurse Angular_DotNET_Projects/* syncgitEshopCommerce/

cd syncgitEshopCommerce

# Configure Git with Azure credentials
git config --global user.email "$AZUSER_EMAIL"
git config --global user.name "$AZUSERNAME"

# Commit and push changes to Azure repository
git add .
git commit -m "sync from git to azure"
git push
