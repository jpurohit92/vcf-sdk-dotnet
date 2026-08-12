# Vcenter.Automation.OpenApi.Model.VcenterVmTemplateLibraryItemsDiskStorageInfo
The Vcenter.VmTemplate.LibraryItems.DiskStorageInfo schema contains storage related information about a virtual machine template's virtual disk.  This schema was added in __vSphere API 6.8__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | **string** | Identifier of the datastore where the disk is stored.  This property was added in __vSphere API 6.8__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Datastore&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Datastore&#x60;. | 
**StoragePolicy** | **string** | Identifier of the storage policy associated with the virtual disk.  This property was added in __vSphere API 6.8__.  If missing or &#x60;null&#x60;, the virtual disk does not have a storage policy associated with it.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.spbm.StorageProfile&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.spbm.StorageProfile&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

