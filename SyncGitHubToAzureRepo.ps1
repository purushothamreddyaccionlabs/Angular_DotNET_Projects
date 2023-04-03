$AZUREPAT = $env:AZUREPAT
$AZUSERNAME = "anything"
$AZUSER_EMAIL = "nageshdevops77@outlook.com"
$AZORG = "Learning-Devops-7777"

# Clone the repository and remove its Git historyy
git clone https://github.com/purushothamreddyaccionlabs/Angular_DotNET_Projects.git
cd Angular_DotNET_Projects
Remove-Item -Recurse -Force .git

cd ..

# Clone the repository again, this time with Azure credentials
$GIT_CMD_REPOSITORY="https://$AZUREPAT@dev.azure.com/Learning-Devops-7777/Abdul/_git/syncgitEshopCommerce"
git clone $GIT_CMD_REPOSITORY

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
