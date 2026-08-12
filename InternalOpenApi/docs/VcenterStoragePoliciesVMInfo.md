# Vcenter.Automation.OpenApi.Model.VcenterStoragePoliciesVMInfo
The Vcenter.Storage.Policies.VM.Info schema contains information about a virtual machine and its virtual disks that are associated with the given storage policy.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VmHome** | **bool** | Flag to indicate whether or not the virtual machine home is associated with the given storage policy.  This property was added in __vSphere API 6.7__. | 
**Disks** | **List&lt;string&gt;** | List of the virtual disks that are associated with the given storage policy.  This property was added in __vSphere API 6.7__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.vm.hardware.Disk&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.vm.hardware.Disk&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

