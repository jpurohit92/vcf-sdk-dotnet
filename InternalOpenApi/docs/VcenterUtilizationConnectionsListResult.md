# Vcenter.Automation.OpenApi.Model.VcenterUtilizationConnectionsListResult
The Vcenter.Utilization.Connections.ListResult schema defines networking information about servers in the vCenter. This contains a list of connections made to each of the server's ports as well as connection limits.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Servers** | [**List&lt;VcenterUtilizationConnectionsServerInfo&gt;**](VcenterUtilizationConnectionsServerInfo.md) | Utilization of listening ports for vCenter server processes.  This property was added in __vSphere API 9.1.0.0__. | 
**UnknownCriteria** | [**VcenterUtilizationConnectionsFilterSpec**](VcenterUtilizationConnectionsFilterSpec.md) | Filtering criteria that could not match any known properties.  This property was added in __vSphere API 9.1.0.0__.  if set, the filtering criteria which are unknown are returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

