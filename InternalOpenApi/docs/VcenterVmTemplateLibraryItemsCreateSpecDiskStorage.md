# Vcenter.Automation.OpenApi.Model.VcenterVmTemplateLibraryItemsCreateSpecDiskStorage
The Vcenter.VmTemplate.LibraryItems.CreateSpecDiskStorage schema defines the storage specification for a virtual machine template's disks.  This schema was added in __vSphere API 6.8__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | **string** | Identifier for the datastore associated with a virtual machine template&#39;s disk.  This property was added in __vSphere API 6.8__.  This property is currently required.    If storage_policy is also specified and is incompatible with the datastore, then the disk will be flagged as being out of compliance with the specified storage policy.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Datastore&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Datastore&#x60;. | [optional] 
**StoragePolicy** | [**VcenterVmTemplateLibraryItemsCreateSpecDiskStoragePolicy**](VcenterVmTemplateLibraryItemsCreateSpecDiskStoragePolicy.md) | Storage policy for a virtual machine template&#39;s disk.  This property was added in __vSphere API 6.8__.  If missing or &#x60;null&#x60;, datastore must be specified and the virtual machine template&#39;s disk is created with the default storage policy associated with the datastore. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

