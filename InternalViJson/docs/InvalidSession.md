# Vcenter.ViJson.OpenApi.Model.InvalidSession

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | [**ManagedObjectReference**](ManagedObjectReference.md) | Deprecated as of vSphere 8.0, use the *NoPermission.missingPrivileges* field.  The managed object on which a permission is required.  | [optional] 
**PrivilegeId** | **string** | Deprecated as of vSphere 8.0, use the *NoPermission.missingPrivileges* field.  The privilege identifier required  | [optional] 
**MissingPrivileges** | [**List&lt;NoPermissionEntityPrivileges&gt;**](NoPermissionEntityPrivileges.md) | List of entities and missing privileges for each entity  ***Since:*** vSphere API Release 7.0.3.2  | [optional] 
**SessionCookie** | **string** | VirtualCenter session cookie that is invalid.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

