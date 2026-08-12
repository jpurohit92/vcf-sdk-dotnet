# Vcenter.ViJson.OpenApi.Model.RemoveEntityPermissionRequestType
The parameters of *AuthorizationManager.RemoveEntityPermission*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | Entity on which a permission is removed.  ***Required privileges:*** Authorization.ModifyPermissions  Refers instance of *ManagedEntity*.  | 
**User** | **string** | User or group for which the permission is defined.  | 
**IsGroup** | **bool** | True, if user refers to a group name; false, for a user name.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

