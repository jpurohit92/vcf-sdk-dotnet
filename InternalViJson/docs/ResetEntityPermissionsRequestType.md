# Vcenter.ViJson.OpenApi.Model.ResetEntityPermissionsRequestType
The parameters of *AuthorizationManager.ResetEntityPermissions*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The entity on which permissions are updated.  ***Required privileges:*** Authorization.ModifyPermissions  Refers instance of *ManagedEntity*.  | 
**Permission** | [**List&lt;Permission&gt;**](Permission.md) | The list of Permission objects that define the new rules for access to the entity and potentially entities below it. If the list is empty, all permissions on the entity are removed.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

