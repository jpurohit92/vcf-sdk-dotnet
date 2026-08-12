# Vcenter.ViJson.OpenApi.Model.ClusterDasFailoverLevelAdvancedRuntimeInfoSlotInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumVcpus** | **int** | Deprecated as of vSphere API 5.0, the number of vcpus is no longer used for slot calculations.  The number of virtual cpus of a slot is defined as the maximum number of virtual cpus any powered on virtual machine has.  | 
**CpuMHz** | **int** | The cpu speed of a slot is defined as the maximum cpu reservation of any powered on virtual machine in the cluster, or any otherwise defined minimum, whichever is larger.  | 
**MemoryMB** | **int** | The memory size of a slot is defined as the maximum memory reservation plus memory overhead of any powered on virtual machine in the cluster, or any otherwise defined minimum, whichever is larger.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

