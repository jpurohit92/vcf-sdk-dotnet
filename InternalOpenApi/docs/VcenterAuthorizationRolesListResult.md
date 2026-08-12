# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationRolesListResult
The Vcenter.Authorization.Roles.ListResult schema contains information about the authorization roles defined in the vCenter Server.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Items** | [**List&lt;VcenterAuthorizationRolesListItem&gt;**](VcenterAuthorizationRolesListItem.md) | The roles that match the specified*Vcenter.Authorization.Roles.FilterSpec* and *Vcenter.Authorization.Roles.IterationSpec* in lexicographical order.  This property was added in __vSphere API 9.0.0.0__. | 
**Marker** | **string** | An opaque marker indicating the last returned role. If there are more roles collected than were returned, the next ones can be retrieved directly by passing this value to another call to #list.     This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; then all of the currently available roles have been returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

