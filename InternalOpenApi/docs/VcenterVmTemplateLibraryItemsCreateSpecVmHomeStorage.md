# Vcenter.Automation.OpenApi.Model.VcenterVmTemplateLibraryItemsCreateSpecVmHomeStorage
The Vcenter.VmTemplate.LibraryItems.CreateSpecVmHomeStorage schema defines the storage specification for a virtual machine template's configuration and log files.  This schema was added in __vSphere API 6.8__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | **string** | Identifier of the datastore for the virtual machine template&#39;s configuration and log files.  This property was added in __vSphere API 6.8__.  This property is currently required.    When storage_policy is also specified and is incompatible with the datastore, then the virtual machine template will be flagged as being out of compliance with the specified storage policy.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Datastore&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Datastore&#x60;. | [optional] 
**StoragePolicy** | [**VcenterVmTemplateLibraryItemsCreateSpecVmHomeStoragePolicy**](VcenterVmTemplateLibraryItemsCreateSpecVmHomeStoragePolicy.md) | Storage policy for the virtual machine template&#39;s configuration and log files.  This property was added in __vSphere API 6.8__.  If missing or &#x60;null&#x60;, datastore must be specified and the virtual machine template&#39;s configuration and log files are created with the default storage policy associated with the datastore. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

