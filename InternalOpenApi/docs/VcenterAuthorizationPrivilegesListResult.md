# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationPrivilegesListResult
The Vcenter.Authorization.Privileges.ListResult schema contains information about the performed privilege checks, if there are any further privilege checks available for reading, and if there are privilege checks potentially missing.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Items** | [**List&lt;VcenterAuthorizationPrivilegesListItem&gt;**](VcenterAuthorizationPrivilegesListItem.md) | The privileges that match the specified*Vcenter.Authorization.Privileges.FilterSpec* and *Vcenter.Authorization.Privileges.IterationSpec* in lexicographical order.  This property was added in __vSphere API 9.0.0.0__. | 
**Marker** | **string** | An opaque marker indicating the last returned privilege. If there are more privileges collected than were returned, the next ones can be retrieved directly by passing this value to another call to {#list}.     This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; then all of the currently available privileges have been returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

