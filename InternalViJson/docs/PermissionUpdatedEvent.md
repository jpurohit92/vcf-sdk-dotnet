# Vcenter.ViJson.OpenApi.Model.PermissionUpdatedEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedEntityEventArgument**](ManagedEntityEventArgument.md) | The entity to which the permission applied.  | 
**Principal** | **string** | The user name or group to which the permission was granted.  | 
**Group** | **bool** | Whether or not the principal was a group.  | 
**Role** | [**RoleEventArgument**](RoleEventArgument.md) | The associated role.  | 
**Propagate** | **bool** | Whether or not the permission applies to sub-entities.  | 
**PrevRole** | [**RoleEventArgument**](RoleEventArgument.md) | The previous associated role.  | [optional] 
**PrevPropagate** | **bool** | Previous propagate value.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

