# Vcenter.Automation.OpenApi.Model.VcenterVmComputePoliciesInfo
The Vcenter.Vm.Compute.Policies.Info schema contains information about the compliance of a virtual machine with a compute policy.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The compliance status of the policy on a specified object.  Possible values:   - &#x60;UNKNOWN&#x60;: The object has an unknown compliance state.   - &#x60;NOT_APPLICABLE&#x60;: The object is in a state for which the policy does not apply.   - &#x60;COMPLIANT&#x60;: The policy is in compliance on the object.   - &#x60;NOT_COMPLIANT&#x60;: The policy is not in compliance on the object.   For more information see: *Vcenter.Compute.Policies.ObjectCompliance*.  This property was added in __vSphere API 7.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

