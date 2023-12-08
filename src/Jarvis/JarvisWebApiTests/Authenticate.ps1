$headers = @{
    "accept" = "*/*"
}

$response = Invoke-RestMethod -Uri "https://localhost:7082/Users/Authenticate" `
    -Method Post `
    -Headers $headers `
    -ContentType "application/json" `
    -Body "{`n  `"username`": `"test`",`n  `"password`": `"test`"`n}"

# remove the file if exists
$fn = 'token.txt'
if (Test-Path $fn) {
    Remove-Item $fn
}

New-Item $fn
# Set-Content $fn $response.token
Add-Content -Path $fn -Value $response.token
# Add-Content -Path $fn -Value $response.token


Write-Output "token is  $($response.token)"