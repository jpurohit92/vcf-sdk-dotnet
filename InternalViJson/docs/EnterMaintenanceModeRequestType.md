# Vcenter.ViJson.OpenApi.Model.EnterMaintenanceModeRequestType
The parameters of *HostSystem.EnterMaintenanceMode_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timeout** | **int** | The task completes when the host successfully enters maintenance mode or the timeout expires, and in the latter case the task contains a Timeout fault. If the timeout is less than or equal to zero, there is no timeout. The timeout is specified in seconds.  | 
**EvacuatePoweredOffVms** | **bool** | This is a parameter only supported by VirtualCenter. If set to true, for a DRS disabled cluster, the task will not succeed unless all powered-off virtual machines have been manually reregistered; for a DRS enabled cluster, VirtualCenter will automatically reregister powered-off virtual machines and a powered-off virtual machine may remain at the host only for two reasons: (a) no compatible host found for reregistration, (b) DRS is disabled for the virtual machine. If set to false, powered-off virtual machines do not need to be moved.  | [optional] 
**MaintenanceSpec** | [**HostMaintenanceSpec**](HostMaintenanceSpec.md) | Any additional actions to be taken by the host upon entering maintenance mode. If omitted, default actions will be taken as documented in the *HostMaintenanceSpec*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

