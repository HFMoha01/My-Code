###################################################
#
# Create Citrix Virtual Apps and Desktops Site with 3 separate databases
#
###################################################
Import-Module Citrix.XenDesktop.Admin
 
Add-PSSnapin Citrix.*
 
########## Parameters #############################
 
$DatabaseServer = "NYC-SQL-001.workspacelab.com"
 
$DatabaseName_Site = "CitrixSITE-NewYorkSite"
 
$DatabaseName_Logging = "CitrixSITE-NewYorkLogging"
 
$DatabaseName_Monitor = "CitrixSITE-NewYorkMonitoring"
 
$CTXSite = "SITE-NewYork"
 
$FullAdminGroup = "WORKSPACELAB\Administrator"
 
$LicenseServer = "NYC-FSR-001.workspacelab.com"
 
$LicenseServer_LicensingModel = "UserDevice"
 
$LicenseServer_ProductCode = "XDT"
 
$LicenseServer_ProductEdition = "PLT"
 
$DatabaseUser = "WORKSPACELAB\Administrator"
 
$DatabasePassword = "Password1" | ConvertTo-SecureString -asPlainText -Force
 
$Database_CredObject = New-Object System.Management.Automation.PSCredential($DatabaseUser,$DatabasePassword)
 
####### Create Databases################
New-XDDatabase -AdminAddress $env:COMPUTERNAME -SiteName $CTXSite -DataStore Site -DatabaseServer $DatabaseServer -DatabaseName $DatabaseName_Site -DatabaseCredentials $Database_CredObject
New-XDDatabase -AdminAddress $env:COMPUTERNAME -SiteName $CTXSite -DataStore Logging -DatabaseServer $DatabaseServer -DatabaseName $DatabaseName_Logging -DatabaseCredentials $Database_CredObject
New-XDDatabase -AdminAddress $env:COMPUTERNAME -SiteName $CTXSite -DataStore Monitor -DatabaseServer $DatabaseServer -DatabaseName $DatabaseName_Monitor -DatabaseCredentials $Database_CredObject 
 
########### Create Site##################
New-XDSite -DatabaseServer $DatabaseServer -LoggingDatabaseName $DatabaseName_Logging -MonitorDatabaseName $DatabaseName_Monitor -SiteDatabaseName $DatabaseName_Site -SiteName $CTXSite -AdminAddress $env:COMPUTERNAME 
 
######## Configure Licensing and confirm the certificate hash#########################
Set-XDLicensing -AdminAddress $env:COMPUTERNAME -LicenseServerAddress $LicenseServer -LicenseServerPort 27000
Set-ConfigSite -AdminAddress $env:COMPUTERNAME -LicensingModel $LicenseServer_LicensingModel -ProductCode $LicenseServer_ProductCode -ProductEdition $LicenseServer_ProductEdition
Set-ConfigSiteMetadata -AdminAddress $env:COMPUTERNAME -Name 'CertificateHash' -Value $(Get-LicCertificate -AdminAddress "https://$LicenseServer").CertHash
