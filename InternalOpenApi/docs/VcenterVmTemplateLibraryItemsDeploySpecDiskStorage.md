# Vcenter.Automation.OpenApi.Model.VcenterVmTemplateLibraryItemsDeploySpecDiskStorage
The Vcenter.VmTemplate.LibraryItems.DeploySpecDiskStorage schema contains the storage specification for disks in the virtual machine.  This schema was added in __vSphere API 6.8__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | **string** | Identifier for the datastore associated the deployed virtual machine&#39;s disk.  This property was added in __vSphere API 6.8__.  This property is currently required.    If storage_policy is also specified and is incompatible with the datastore, then the disk will be flagged as being out of compliance with the specified storage policy.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Datastore&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Datastore&#x60;. | [optional] 
**StoragePolicy** | [**VcenterVmTemplateLibraryItemsDeploySpecDiskStoragePolicy**](VcenterVmTemplateLibraryItemsDeploySpecDiskStoragePolicy.md) | Storage policy for the deployed virtual machine&#39;s disk.  This property was added in __vSphere API 6.8__.  If missing or &#x60;null&#x60;, datastore must be specified and the deployed virtual machine&#39;s disk is created with the default storage policy associated with the datastore. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

