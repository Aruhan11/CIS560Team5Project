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
& ".\DropDatabase.ps1" -Database $Database
& ".\CreateDatabase.ps1" -Database $Database

<#
   If on the department's server, you don't have permissions to drop or create databases.
   In this case, maintain a script to drop all tables.
#>
#Write-Host "Dropping tables..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Schemas\Library.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.CreatorType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.AssetType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.Category.sql"


Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.Creator.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.User.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.CreatorCreatorType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.Librarian.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.Asset.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.AssetCategory.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Tables\Library.CheckedOutAsset.sql"



Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.CreateCheckOutAsset.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.CreateUser.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.DeleteUser.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.FetchAsset.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.FetchCheckOutAsset.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.FetchCheckOutHistory.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.FetchCreator.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.FetchLibrarian.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.FetchProductionsOfCreator.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.FetchSituationOfAsset.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.FetchUser.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.GetCreatorsByType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.GetPossibleAssets.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.GetUser.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.InsertAsset.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.InsertAssetCategory.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.InsertCreator.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.RankingAssetByAssetType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.RankingCreatorByAssetType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.RankingCreatorByUser.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.RetriveAssets.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.RetriveCheckOutAssets.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.RetriveCreators.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.RetriveLibrarians.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.RetriveUsers.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.TopTenAssetsStillAvaliable.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.UpdateAsset.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.UpdateCheckOutAsset.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.UpdateCreator.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.UpdateUser.sql"






Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Procedures\Library.UpdateUser.sql"
Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Data\Library.CreatorType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Data\Library.AssetType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Data\Library.Category.sql"


Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Data\Library.Creator.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Data\Library.User.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Data\Library.CreatorCreatorType.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Data\Library.Librarian.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Data\Library.Asset.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Data\Library.AssetCategory.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "LibraryData\Sql\Data\Library.CheckedOutAsset.sql"


Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
