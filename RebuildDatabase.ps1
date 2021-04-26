Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "CIS560"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name SqlServer;

# Install the SQL Server Module
# Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

<#
   If on your local machine, you can drop and re-create the database.
#>
& ".\Scripts\DropDatabase.ps1" -Database $Database
& ".\Scripts\CreateDatabase.ps1" -Database $Database

<#
   If on the department's server, you don't have permissions to drop or create databases.
   In this case, maintain a script to drop all tables.
#>
#Write-Host "Dropping tables..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\DropTables.sql"DO THIS

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Schemas\Library.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.Asset.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.AssetCategory.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.AssetType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.Category.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.CheckedOutAsset.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.Creator.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.CreatorCreatorType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.CreatorType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.Lirarian.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.User.sql"

Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.CreateUser.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.DeleteUser.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.FetchCheckOutHistory.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.FetchProductionsOfCreator.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.FetchSituationOfAsset.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.FetchUser.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.GetCreatorsByType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.GetPossibleAssets.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.GetUser.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.InsertAsset.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.RankingAssetByAssetType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.RankingCreatorByAssetType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.RankingCreatorByUser.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.SavePhoneNumber.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.TopTenAssetsStillAvaliable.sql"

Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Data\Library.User.sql"


Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
