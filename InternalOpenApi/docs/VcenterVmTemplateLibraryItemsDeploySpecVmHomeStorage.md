# Vcenter.Automation.OpenApi.Model.VcenterVmTemplateLibraryItemsDeploySpecVmHomeStorage
The Vcenter.VmTemplate.LibraryItems.DeploySpecVmHomeStorage schema defines the storage specification for a deployed virtual machine's configuration and log files.  This schema was added in __vSphere API 6.8__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | **string** | Identifier of the datastore for the deployed virtual machine&#39;s configuration and log files.  This property was added in __vSphere API 6.8__.  This property is currently required.    When storage_policy is also specified and is incompatible with the datastore, then the deployed virtual machine will be flagged as being out of compliance with the specified storage policy.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Datastore&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Datastore&#x60;. | [optional] 
**StoragePolicy** | [**VcenterVmTemplateLibraryItemsDeploySpecVmHomeStoragePolicy**](VcenterVmTemplateLibraryItemsDeploySpecVmHomeStoragePolicy.md) | Storage policy for the deployed virtual machine&#39;s configuration and log files.  This property was added in __vSphere API 6.8__.  If missing or &#x60;null&#x60;, datastore must be specified and the deployed virtual machine&#39;s configuration and log files are created with the default storage policy associated with the datastore. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

