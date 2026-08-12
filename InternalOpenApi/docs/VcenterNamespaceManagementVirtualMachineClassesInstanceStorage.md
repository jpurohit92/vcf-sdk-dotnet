# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementVirtualMachineClassesInstanceStorage
The Vcenter.NamespaceManagement.VirtualMachineClasses.InstanceStorage schema encapsulates information about storage policy and instance storage volumes.  This schema was added in __vSphere API 8.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policy** | **string** | Policy corresponding to the instance storage. To use VM class with instance storage, this policy should also be associated with Supervisor namespace. See *Vcenter.Namespaces.Instances.StorageSpec*.  This property was added in __vSphere API 8.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;SpsStorageProfile&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;SpsStorageProfile&#x60;. | 
**Volumes** | [**List&lt;VcenterNamespaceManagementVirtualMachineClassesInstanceStorageVolume&gt;**](VcenterNamespaceManagementVirtualMachineClassesInstanceStorageVolume.md) | List of instance storage volumes. At least one volume is required when configuring a VM class with instance storage.  This property was added in __vSphere API 8.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

