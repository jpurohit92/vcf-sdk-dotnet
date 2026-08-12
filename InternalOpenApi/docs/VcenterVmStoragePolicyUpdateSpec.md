# Vcenter.Automation.OpenApi.Model.VcenterVmStoragePolicyUpdateSpec
The Vcenter.Vm.Storage.Policy.UpdateSpec schema describes the updates to be made to the storage policies associated with the virtual machine home and/or its virtual disks.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VmHome** | [**VcenterVmStoragePolicyVmHomePolicySpec**](VcenterVmStoragePolicyVmHomePolicySpec.md) | Storage policy to be used when reconfiguring the virtual machine home.  This property was added in __vSphere API 6.7__.  if missing or &#x60;null&#x60; the current storage policy is retained. | [optional] 
**Disks** | [**Dictionary&lt;string, VcenterVmStoragePolicyDiskPolicySpec&gt;**](VcenterVmStoragePolicyDiskPolicySpec.md) | Storage policy or policies to be used when reconfiguring virtual machine disk.  This property was added in __vSphere API 6.7__.  if missing or &#x60;null&#x60; the current storage policy is retained.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.vcenter.vm.hardware.Disk&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.vcenter.vm.hardware.Disk&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

