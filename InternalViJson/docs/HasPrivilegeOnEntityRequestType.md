# Vcenter.ViJson.OpenApi.Model.HasPrivilegeOnEntityRequestType
The parameters of *AuthorizationManager.HasPrivilegeOnEntity*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The entity on which the privileges are checked.  ***Required privileges:*** System.Read  Refers instance of *ManagedEntity*.  | 
**SessionId** | **string** | The session ID to check privileges for. A session ID can be obtained from *UserSession.key*.  | 
**PrivId** | **List&lt;string&gt;** | The array of privilege IDs to check.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

