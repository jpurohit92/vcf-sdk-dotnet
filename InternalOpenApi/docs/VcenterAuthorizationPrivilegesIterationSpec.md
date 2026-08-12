# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationPrivilegesIterationSpec
The Vcenter.Authorization.Privileges.IterationSpec schema contains properties used to break results into pages when listing privileges, see *GET /vcenter/authorization/privileges*).  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PageSize** | **long** | Maximum number of records to return in one call. Clients can limit the response size to a number of records they feel comfortable handling with this setting. A service policy can overwrite it to something that is less than the value specified by the client.     This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; defaults to 200 privileges. | [optional] 
**Marker** | **string** | The marker is a simple cursor (pointer) pointing to the position of the last record that has been previously returned. By using the marker, the client is guaranteed to iterate through all records without repetition.    Presenting a marker means that only the records after the position to which the marker points will be returned to the client.    This value is obtained from #list operation.     This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, first page of records will be returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

