# Vcenter.ViJson.OpenApi.Model.UplinkPortMtuNotSupportEvent
Mtu health check status of an uplink port is changed, and in the latest mtu health check, not all the vlans' MTU setting on physical switch allows vSphere Distributed Switch max MTU size packets passing. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SwitchUuid** | **string** | UUID of the DVS the host is connected to.  | 
**HealthResult** | [**HostMemberHealthCheckResult**](HostMemberHealthCheckResult.md) | Health check status.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

