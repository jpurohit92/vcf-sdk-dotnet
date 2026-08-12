# Vcenter.ViJson.OpenApi.Model.SetEntityPermissionsRequestType
The parameters of *AuthorizationManager.SetEntityPermissions*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The entity on which to set permissions.  ***Required privileges:*** Authorization.ModifyPermissions  Refers instance of *ManagedEntity*.  | 
**Permission** | [**List&lt;Permission&gt;**](Permission.md) | An array of specifications for permissions on the entity.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

