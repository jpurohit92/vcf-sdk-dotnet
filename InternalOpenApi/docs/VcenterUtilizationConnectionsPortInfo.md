# Vcenter.Automation.OpenApi.Model.VcenterUtilizationConnectionsPortInfo
The Vcenter.Utilization.Connections.PortInfo schema defines the utilization of a vCenter TCP server port.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the server port, for example \&quot;http\&quot;.  This property was added in __vSphere API 9.1.0.0__.  It is missing or &#x60;null&#x60; if the port has no standard name. | [optional] 
**Description** | **string** | Description of the server port.  This property was added in __vSphere API 9.1.0.0__.  It is missing or &#x60;null&#x60; if the port has no description. | [optional] 
**Port** | **long** | The server port number.  This property was added in __vSphere API 9.1.0.0__. | 
**OpenConnections** | **long** | The count of open TCP connections to this server.  This property was added in __vSphere API 9.1.0.0__. | 
**Peers** | [**List&lt;VcenterUtilizationConnectionsPeerInfo&gt;**](VcenterUtilizationConnectionsPeerInfo.md) | The list of peers connected to this server port.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

