# Vcenter.ViJson.OpenApi.Model.HasUserPrivilegeOnEntitiesRequestType
The parameters of *AuthorizationManager.HasUserPrivilegeOnEntities*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entities** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | are the managed objects to check privileges on. If they refer to managed objects that are not managed entities the privilege check will be done on the root folder.  ***Required privileges:*** System.View  | 
**UserName** | **string** | is the name of the user to check privileges for. Both UPN and PreWindows2000LogonName user name formats are supported.  | 
**PrivId** | **List&lt;string&gt;** | is the set of privileges to check for  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

