# Vcenter.Automation.OpenApi.Model.VcenterVmStoragePolicyComplianceCheckSpec
The Vcenter.Vm.Storage.Policy.Compliance.CheckSpec schema contains properties used to specify the entities on which the storage policy compliance check is to be invoked.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VmHome** | **bool** | Invoke compliance check on the virtual machine home directory if set to true.  This property was added in __vSphere API 6.7__. | 
**Disks** | **List&lt;string&gt;** | Identifiers of the virtual machine&#39;s virtual disks for which compliance should be checked.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; or empty, compliance check is invoked on all the associated disks.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.vm.hardware.Disk&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.vm.hardware.Disk&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

