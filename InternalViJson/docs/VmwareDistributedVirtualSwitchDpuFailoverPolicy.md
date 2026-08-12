# Vcenter.ViJson.OpenApi.Model.VmwareDistributedVirtualSwitchDpuFailoverPolicy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveUplink** | **List&lt;string&gt;** | The name of the active uplink(s).  These uplink(s) must be backed by vmnic(s) from a single DPU.  | [optional] 
**StandbyUplink** | **List&lt;string&gt;** | The name of the standby uplink(s).  These uplink(s) must be backed by vmnic(s) from a different DPU than the active uplink(s). An empty standbyUplink indicates that no failover action will be taken after the active DPU fails.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

