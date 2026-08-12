# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryBackupBackupRequest
Appliance.Recovery.Backup.BackupRequest schema Structure representing requested backup piece

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Parts** | **List&lt;string&gt;** | a list of optional parts. Run backup parts APIs to get list of optional parts and description | 
**BackupPassword** | **string** | a password for a backup piece The backupPassword must adhere to the following password requirements: At least 8 characters, cannot be more than 20 characters in length. At least 1 uppercase letter. At least 1 lowercase letter. At least 1 numeric digit. At least 1 special character (i.e. any character not in [0-9,a-z,A-Z]). Only visible ASCII characters (for example, no space).  backupPassword If no password then the piece will not be encrypted | [optional] 
**LocationType** | **string** | a type of location  Possible values:   - &#x60;FTP&#x60;: Destination is FTP server   - &#x60;HTTP&#x60;: Destination is HTTP server   - &#x60;FTPS&#x60;: Destination is FTPS server   - &#x60;HTTPS&#x60;: Destination is HTTPS server   - &#x60;SCP&#x60;: Destination is SSH server   - &#x60;SFTP&#x60;: Destination is SFTP server   - &#x60;NFS&#x60;: Destination is NFS server  This constant was added in __vSphere API 6.7.2__.   - &#x60;SMB&#x60;: Destination is SMB server  This constant was added in __vSphere API 6.7.2__.   For more information see: *Appliance.Recovery.Backup.LocationType*. | 
**Location** | **string** | path or url | 
**LocationUser** | **string** | username for location  locationUser User name for this location if login is required. | [optional] 
**LocationPassword** | **string** | password for location  locationPassword Password for the specified user if login is required at this location. | [optional] 
**Comment** | **string** | Custom comment  comment an optional comment | [optional] 
**FastBackup** | **bool** | Option to enable Postgres DB/ VCDB fast backup.  If missing or &#x60;null&#x60; backup will proceed at slow rate | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

