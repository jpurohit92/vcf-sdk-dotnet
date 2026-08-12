# Vcenter.Automation.OpenApi.Model.VcenterUtilizationConnectionsServerInfo
The Vcenter.Utilization.Connections.ServerInfo schema defines the utilization of listening ports for a server process.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Service** | **string** | The name of the service which hosts the server.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.services.Service&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.services.Service&#x60;. | 
**Ports** | [**List&lt;VcenterUtilizationConnectionsPortInfo&gt;**](VcenterUtilizationConnectionsPortInfo.md) | List of listening ports of this server and their open TCP connections.  This property was added in __vSphere API 9.1.0.0__. | 
**TotalConnections** | **long** | The total amount of connections to the ports listed in *Vcenter.Utilization.Connections.ServerInfo.ports*.  This property was added in __vSphere API 9.1.0.0__. | 
**ConnectionLimit** | **long** | The limit for the connections this server is allowed to accept before it starts denying connection attempts. This limit is shared between all *Vcenter.Utilization.Connections.ServerInfo.ports*. This is the maximum value of *Vcenter.Utilization.Connections.ServerInfo.total_connections*.  This property was added in __vSphere API 9.1.0.0__.  Only set if the server has a connection limit. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

