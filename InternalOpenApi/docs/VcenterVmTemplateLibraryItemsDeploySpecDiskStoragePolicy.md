# Vcenter.Automation.OpenApi.Model.VcenterVmTemplateLibraryItemsDeploySpecDiskStoragePolicy
The Vcenter.VmTemplate.LibraryItems.DeploySpecDiskStoragePolicy schema describes the storage policy specification for the deployed virtual machine's disks.  This schema was added in __vSphere API 6.8__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Policy type to be used when creating the deployed virtual machine&#39;s disk.  Possible values:   - &#x60;USE_SPECIFIED_POLICY&#x60;: Use the specified policy.   - &#x60;USE_SOURCE_POLICY&#x60;: Use the storage policy that is associated with the corresponding disk in the source virtual machine template.   For more information see: *Vcenter.VmTemplate.LibraryItems.DeploySpecDiskStoragePolicy.Type*.  This property was added in __vSphere API 6.8__. | 
**Policy** | **string** | Identifier of the storage policy to use.  This property was added in __vSphere API 6.8__.  This property is optional and it is only relevant when the value of type is *Vcenter.VmTemplate.LibraryItems.DeploySpecDiskStoragePolicy.Type.USE_SPECIFIED_POLICY*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.spbm.StorageProfile&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.spbm.StorageProfile&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

