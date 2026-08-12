# Vcenter.ViJson.OpenApi.Model.HostPosixAccountSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID of the specified account.  | 
**Password** | **string** | The password for a user or group.  | [optional] 
**Description** | **string** | The description of the specified account.  | [optional] 
**PosixId** | **int** | Deprecated as of vSphere API 5.1, this property is deprecated and is ignored.  The user ID or group ID of a specified account.  | [optional] 
**ShellAccess** | **bool** | Grants shell access.  As of vSphere API 5.1, this property is deprecated and is ignored. *HostLocalAccountManager.CreateUser* will always set this to true, and *HostLocalAccountManager.UpdateUser* will set it to true if it is already false. Also shell access is granted only to users with Administrator role on the root folder and no other non-Admin role on any other inventory object.  As of vSphere API 7.0.3.2, this property is no longer ignored and it must be true if a user with administrator permissions needs shell access. It can be set to true for other users only by administrators who themselves have this shell access. Administrators without shell access cannot change the passwords of users with shell access. Setting this property to false for user &#39;root&#39; has no effect.  If this property is not specified when creating a new user account then the default value depends on the following factors: if the calling user does not have shell access then it defaults to false; if the calling user has shell access then it defaults to true, unless overridden by host configuration settings.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

