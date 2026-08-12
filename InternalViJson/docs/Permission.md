# Vcenter.ViJson.OpenApi.Model.Permission

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | Managed entity the permission is defined on.  Left unset when calling setPermissions or resetPermissions, but present for the results of permission queries.  Refers instance of *ManagedEntity*.  | [optional] 
**Principal** | **string** | User or group receiving access in the form of \&quot;login\&quot; for local or \&quot;DOMAIN\\\\login\&quot; for users in a Windows domain.  | 
**Group** | **bool** | Whether principal refers to a user or a group.  True for a group and false for a user.  | 
**RoleId** | **int** | Reference to the role providing the access.  | 
**Propagate** | **bool** | Whether or not this permission propagates down the hierarchy to sub-entities.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

