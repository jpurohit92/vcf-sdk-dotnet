# Vcenter.Automation.OpenApi.Model.VcenterVmStoragePolicyInfo
The Vcenter.Vm.Storage.Policy.Info schema contains information about the storage policies associated with virtual machine's home directory and virtual hard disks.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VmHome** | **string** | Storage Policy associated with virtual machine home.  This property was added in __vSphere API 6.7__.  Ifmissing or &#x60;null&#x60;, the virtual machine&#39;s home directory doesn&#39;t have any storage policy.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.StoragePolicy&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.StoragePolicy&#x60;. | [optional] 
**Disks** | **Dictionary&lt;string, string&gt;** | Storage policies associated with virtual disks. The values in this map are storage policy identifiers. They will be identifiers for the resource type:com.vmware.vcenter.StoragePolicy If the map is empty, the virtual machine does not have any disks or its disks are not associated with a storage policy.  This property was added in __vSphere API 6.7__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.vcenter.vm.hardware.Disk&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.vcenter.vm.hardware.Disk&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

