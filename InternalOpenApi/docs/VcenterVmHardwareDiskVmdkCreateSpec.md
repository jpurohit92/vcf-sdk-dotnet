# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareDiskVmdkCreateSpec
The Vcenter.Vm.Hardware.Disk.VmdkCreateSpec schema provides a specification for creating a new VMDK file to be used as a backing for a virtual disk. The virtual disk will be stored in the same directory as the virtual machine's configuration file.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Base name of the VMDK file. The name should not include the &#39;.vmdk&#39; file extension.  If missing or &#x60;null&#x60;, a name (derived from the name of the virtual machine) will be chosen by the server. | [optional] 
**Capacity** | **long** | Capacity of the virtual disk backing in bytes.  If missing or &#x60;null&#x60;, defaults to a guest-specific capacity. | [optional] 
**StoragePolicy** | [**VcenterVmHardwareDiskStoragePolicySpec**](VcenterVmHardwareDiskStoragePolicySpec.md) | The Vcenter.Vm.Hardware.Disk.StoragePolicySpec schema contains information about the storage policy that is to be associated the with VMDK file.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the default storage policy of the target datastore (if applicable) is applied. Currently a default storage policy is only supported by object based datastores : VVol &amp; vSAN. For non- object datastores, if missing or &#x60;null&#x60; then no storage policy would be associated with the VMDK file. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

