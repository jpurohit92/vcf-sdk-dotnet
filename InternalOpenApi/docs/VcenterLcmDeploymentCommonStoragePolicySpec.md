# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentCommonStoragePolicySpec
The Vcenter.Lcm.Deployment.Common.StoragePolicySpec schema contains information about the storage policy to be associated with a virtual machine object.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policy** | **string** | Identifier of the storage policy which should be associated with the virtual machine.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.StoragePolicy&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.StoragePolicy&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

