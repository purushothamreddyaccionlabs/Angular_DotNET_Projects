$content = Get-Content -Path D:\a\1\s\src\app\service-API\api-services.service.ts
$content = $content -replace 'https://localhost:7103', 'https://backend-eshopcommerce.azurewebsites.net'
Set-Content -Path D:\a\1\s\src\app\service-API\api-services.service.ts -Value $content
