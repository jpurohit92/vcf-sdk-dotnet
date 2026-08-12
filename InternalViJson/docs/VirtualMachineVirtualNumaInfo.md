# Vcenter.ViJson.OpenApi.Model.VirtualMachineVirtualNumaInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CoresPerNumaNode** | **int** | Cores per NUMA node.  When this virtual machine is powered off and \&quot;autoCoresPerNumaNode\&quot; is True, coresPerNumaNode will be assigned during power-on and this field should be ignored. In other cases, this field represents the virtual NUMA node size seen by the guest.  | [optional] 
**AutoCoresPerNumaNode** | **bool** | Whether coresPerNode is determined automatically.  | [optional] 
**VnumaOnCpuHotaddExposed** | **bool** | Whether virtual NUMA topology is exposed when CPU hotadd is enabled.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

