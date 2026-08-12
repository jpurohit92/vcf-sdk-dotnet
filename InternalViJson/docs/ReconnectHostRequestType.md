# Vcenter.ViJson.OpenApi.Model.ReconnectHostRequestType
The parameters of *HostSystem.ReconnectHost_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CnxSpec** | [**HostConnectSpec**](HostConnectSpec.md) | Includes the parameters to use, including user name and password, when reconnecting to the host. If this parameter is not specified, the default connection parameters is used.  | [optional] 
**ReconnectSpec** | [**HostSystemReconnectSpec**](HostSystemReconnectSpec.md) | Includes connection parameters specific to reconnect. This will mainly be used to indicate how to handle divergence between the host settings and vCenter Server settings when the host was disconnected.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

