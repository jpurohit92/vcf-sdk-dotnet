# Vcenter.ViJson.OpenApi.Model.QueryMemoryOverheadRequestType
The parameters of *HostSystem.QueryMemoryOverhead*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MemorySize** | **long** | The amount of virtual system RAM, in bytes. For an existing virtual machine, this value can be found (in megabytes) as the memoryMB property of the *VirtualHardware*.  | 
**VideoRamSize** | **int** | The amount of virtual video RAM, in bytes. For an existing virtual machine on a host that supports advertising this property, this value can be found (in kilobytes) as the videoRamSizeInKB property of the *VirtualMachineVideoCard*. If this parameter is left unset, the default video RAM size for virtual machines on this host is assumed.  | [optional] 
**NumVcpus** | **int** | The number of virtual CPUs. For an existing virtual machine, this value can be found as the numCPU property of the *VirtualHardware*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

