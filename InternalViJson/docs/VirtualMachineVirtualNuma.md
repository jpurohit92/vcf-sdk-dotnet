# Vcenter.ViJson.OpenApi.Model.VirtualMachineVirtualNuma

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CoresPerNumaNode** | **int** | Cores per vNUMA node for this VM.  The number of vNUMA nodes is calculated by total number of cores divided by corePerNumaNode. If set to be zero, it clears any manual override and autosize vNUMA node. If set to be non zero, VM uses the value as vNUMA node size. If unset, the VM continue to follow the behavior in last poweron.  | [optional] 
**ExposeVnumaOnCpuHotadd** | **bool** | Capability to expose virtual NUMA when CPU hotadd is enabled.  If set to true, ESXi will consider exposing virtual NUMA to the VM when CPU hotadd is enabled. If set to false, ESXi will enforce the VM to have single virtual NUMA node when CPU hotadd is enabled. If unset, the VM continue to follow the behavior in last poweron.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

