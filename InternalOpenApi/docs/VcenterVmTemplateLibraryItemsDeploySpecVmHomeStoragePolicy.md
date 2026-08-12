# Vcenter.Automation.OpenApi.Model.VcenterVmTemplateLibraryItemsDeploySpecVmHomeStoragePolicy
The Vcenter.VmTemplate.LibraryItems.DeploySpecVmHomeStoragePolicy schema defines the storage policy specification for the deployed virtual machine's configuration and log files.  This schema was added in __vSphere API 6.8__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Policy type to be used when creating the deployed virtual machine&#39;s configuration and log files.  Possible values:   - &#x60;USE_SPECIFIED_POLICY&#x60;: Use the specified policy.   - &#x60;USE_SOURCE_POLICY&#x60;: Use the storage policy that is associated with the source virtual machine template&#39;s configuration and log files.   For more information see: *Vcenter.VmTemplate.LibraryItems.DeploySpecVmHomeStoragePolicy.Type*.  This property was added in __vSphere API 6.8__. | 
**Policy** | **string** | Identifier for the storage policy to use.  This property was added in __vSphere API 6.8__.  This property is optional and it is only relevant when the value of type is *Vcenter.VmTemplate.LibraryItems.DeploySpecVmHomeStoragePolicy.Type.USE_SPECIFIED_POLICY*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.spbm.StorageProfile&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.spbm.StorageProfile&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

