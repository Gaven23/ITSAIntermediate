# JvR 20200226 - execute all *.sql files in folder

# Usage Examples:
#   
#   .\sql-execute-folder.ps1
#   .\sql-execute-folder.ps1 -server localhost -db SmarthubConnect -folderPath 'C:\SourceCode\SmartHub Connect\sql'
#   .\sql-execute-folder.ps1 -server localhost -db SmarthubConnect -folderPath 'C:\SourceCode\SmartHub Connect\sql' -username sa -password foo
    
param([string]$server = 'dev-san-sql1.database.windows.net',
      [string]$db = 'SHC-DEV-LOGISTICS',
      [string]$folderPath = '.',
      [string]$username='',
      [string]$password='',
      [bool]$useActiveDirectory=$false)


if ($useActiveDirectory) {
    # https://docs.microsoft.com/en-us/powershell/module/sqlserver/invoke-sqlcmd?view=sqlserver-ps#example-11--connect-to-azure-sql-databases--or-managed-instance--using-a-service-principal
    # Connect-AzAccount
    $accessToken = (Get-AzAccessToken -ResourceUrl https://database.windows.net).Token
}

Get-ChildItem -Path $folderPath -Include '*.sql' -Recurse |
ForEach-Object {

    if ($useActiveDirectory) {
        Invoke-Sqlcmd -ServerInstance $server -Database $db -AccessToken $accessToken -InputFile $_
    }
    elseif ([string]::IsNullOrWhiteSpace($username)) {
        Invoke-Sqlcmd -ServerInstance $server -Database $db -InputFile $_
    }
    else {
        Invoke-Sqlcmd -ServerInstance $server -Database $db -Username $username -Password $password -InputFile $_
    }
    
}