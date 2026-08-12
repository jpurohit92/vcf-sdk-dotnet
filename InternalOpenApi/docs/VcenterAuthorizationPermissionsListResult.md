# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationPermissionsListResult
The Vcenter.Authorization.Permissions.ListResult schema contains information about the authorization permissions defined in the vCenter Server.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Items** | [**List&lt;VcenterAuthorizationPermissionsListItem&gt;**](VcenterAuthorizationPermissionsListItem.md) | The permissions that match the specified*Vcenter.Authorization.Permissions.FilterSpec* and *Vcenter.Authorization.Permissions.IterationSpec* in lexicographical order.  This property was added in __vSphere API 9.0.0.0__. | 
**Marker** | **string** | An opaque marker indicating the last returned permission. If there are more permissions collected than were returned, the next ones can be retrieved directly by passing this value to another call to #list.     This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; then all of the currently available permissions have been returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

