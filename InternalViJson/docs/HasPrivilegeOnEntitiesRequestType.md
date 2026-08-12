# Vcenter.ViJson.OpenApi.Model.HasPrivilegeOnEntitiesRequestType
The parameters of *AuthorizationManager.HasPrivilegeOnEntities*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The set of entities on which the privileges are checked.  ***Required privileges:*** System.Read  Refers instances of *ManagedEntity*.  | 
**SessionId** | **string** | The session ID to check privileges for. A session ID can be obtained from *UserSession.key*.  | 
**PrivId** | **List&lt;string&gt;** | The array of privilege IDs to check.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

