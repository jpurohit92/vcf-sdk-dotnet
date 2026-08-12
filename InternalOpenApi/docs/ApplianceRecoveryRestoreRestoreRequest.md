# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryRestoreRestoreRequest
Appliance.Recovery.Restore.RestoreRequest schema Structure representing requested restore piece

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Parts** | **List&lt;string&gt;** | List of standalone parts to restore. Only parts with the *Appliance.Recovery.Backup.Parts.Part.standalone* flag set to &#x60;true&#x60; can be included.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; entire VCSA will be restored. | [optional] 
**BackupPassword** | **string** | a password for a backup piece  backupPassword If no password then the piece will not be decrypted | [optional] 
**LocationType** | **string** | a type of location  Possible values:   - &#x60;FTP&#x60;: Destination is FTP server   - &#x60;HTTP&#x60;: Destination is HTTP server   - &#x60;FTPS&#x60;: Destination is FTPS server   - &#x60;HTTPS&#x60;: Destination is HTTPS server   - &#x60;SCP&#x60;: Destination is SSH server   - &#x60;SFTP&#x60;: Destination is SFTP server   - &#x60;NFS&#x60;: Destination is NFS server  This constant was added in __vSphere API 6.7.2__.   - &#x60;SMB&#x60;: Destination is SMB server  This constant was added in __vSphere API 6.7.2__.   For more information see: *Appliance.Recovery.Restore.LocationType*. | 
**Location** | **string** | path or url | 
**LocationUser** | **string** | username for location  locationUser User name for this location if login is required. | [optional] 
**LocationPassword** | **string** | password for location  locationPassword Password for the specified user if login is required at this location. | [optional] 
**SsoAdminUserName** | **string** | Administrators username for SSO.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; SSO authentication will not be used. If the vCenter Server is a management node or an embedded node, authentication is required. | [optional] 
**SsoAdminUserPassword** | **string** | The password for SSO admin user.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; SSO authentication will not be used. If the vCenter Server is a management node or an embedded node, authentication is required. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

