# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryBackupJobBackupRequest
The Appliance.Recovery.Backup.Job.BackupRequest schema represents a requested backup piece.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Parts** | **List&lt;string&gt;** | List of optional parts that will be included in the backup. Use the *GET /appliance/recovery/backup/parts* operation to get information about the supported parts. | 
**BackupPassword** | **string** | Password for a backup piece. The backupPassword must adhere to the following password requirements: At least 8 characters, cannot be more than 20 characters in length. At least 1 uppercase letter. At least 1 lowercase letter. At least 1 numeric digit. At least 1 special character (i.e. any character not in [0-9,a-z,A-Z]). Only visible ASCII characters (for example, no space).  backupPassword If no password then the piece will not be encrypted | [optional] 
**LocationType** | **string** | Type of backup location.  Possible values:   - &#x60;FTP&#x60;: Destination is FTP server.   - &#x60;HTTP&#x60;: Destination is HTTP server.   - &#x60;FTPS&#x60;: Destination is FTPS server.   - &#x60;HTTPS&#x60;: Destination is HTTPS server.   - &#x60;SCP&#x60;: Destination is SSH server.   - &#x60;SFTP&#x60;: Destination is SFTP server.   - &#x60;NFS&#x60;: Destination is NFS server.  This constant was added in __vSphere API 6.7.2__.   - &#x60;SMB&#x60;: Destination is SMB server.  This constant was added in __vSphere API 6.7.2__.   For more information see: *Appliance.Recovery.Backup.Job.LocationType*. | 
**Location** | **string** | Path or URL of the backup location. | 
**LocationUser** | **string** | Username for the given location.  If missing or &#x60;null&#x60; authentication will not be used for the specified location. | [optional] 
**LocationPassword** | **string** | Password for the given location.  If missing or &#x60;null&#x60; authentication will not be used for the specified location. | [optional] 
**Comment** | **string** | Custom comment provided by the user.  If missing or &#x60;null&#x60; comment will be empty. | [optional] 
**FastBackup** | **bool** | Option to enable Postgres DB/ VCDB fast backup  If missing or &#x60;null&#x60; backup will proceed at slow rate | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

