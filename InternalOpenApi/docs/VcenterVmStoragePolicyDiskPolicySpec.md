# Vcenter.Automation.OpenApi.Model.VcenterVmStoragePolicyDiskPolicySpec
The Vcenter.Vm.Storage.Policy.DiskPolicySpec schema provides a specification for the storage policy to be associated with the virtual disks.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Policy type to be used while performing update operation on the virtual disks.  Possible values:   - &#x60;USE_SPECIFIED_POLICY&#x60;: Use the specified policy (see *Vcenter.Vm.Storage.Policy.DiskPolicySpec.policy*).   - &#x60;USE_DEFAULT_POLICY&#x60;: Use the default storage policy of the datastore.   For more information see: *Vcenter.Vm.Storage.Policy.DiskPolicySpec.PolicyType*.  This property was added in __vSphere API 6.7__. | 
**Policy** | **string** | Storage Policy identification.  This property was added in __vSphere API 6.7__.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Storage.Policy.DiskPolicySpec.PolicyType.USE_SPECIFIED_POLICY*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.StoragePolicy&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.StoragePolicy&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

