# Vcenter.ViJson.OpenApi.Model.PowerDownHostToStandByRequestType
The parameters of *HostSystem.PowerDownHostToStandBy_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TimeoutSec** | **int** | The task completes when the host successfully enters standby mode and stops sending heartbeat signals. If heartbeats are still coming after timeoutSecs seconds, the host is declared timedout, and the task is assumed failed.  | 
**EvacuatePoweredOffVms** | **bool** | This is a parameter used only by VirtualCenter. If set to true, for a DRS disabled cluster, the task will not succeed unless all powered-off virtual machines have been manually reregistered; for a DRS enabled cluster, VirtualCenter will automatically reregister powered-off virtual machines and a powered-off virtual machine may remain at the host only for two reasons: (a) no compatible host found for reregistration, (b) DRS is disabled for the virtual machine.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

