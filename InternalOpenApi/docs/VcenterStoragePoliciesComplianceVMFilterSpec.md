# Vcenter.Automation.OpenApi.Model.VcenterStoragePoliciesComplianceVMFilterSpec
The Vcenter.Storage.Policies.Compliance.VM.FilterSpec schema contains Status used to filter the results when listing virtual machines (see *GET /vcenter/storage/policies/compliance/vm*).  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **List&lt;string&gt;** | Compliance Status that a virtual machine must have to match the filter. Atleast one status must be specified.  Possible values:   - &#x60;COMPLIANT&#x60;: The virtual machine or virtual disk is in compliance.   - &#x60;NON_COMPLIANT&#x60;: The virtual machine or virtual disk is in not in compliance.   - &#x60;UNKNOWN_COMPLIANCE&#x60;: Compliance status of the virtual machine or virtual disk is not known.   - &#x60;NOT_APPLICABLE&#x60;: Compliance computation is not applicable for this virtual machine or disk because it does not have any storage requirement that apply to the object-based datastore on which the entity is placed.   - &#x60;OUT_OF_DATE&#x60;: Compliance status becomes out of date when the profile associated with the virtual machine or disk is edited and not applied. The compliance status will remain out of date until the latest policy is applied.   For more information see: *Vcenter.Storage.Policies.Compliance.VM.Status*.  This property was added in __vSphere API 6.7__. | 
**Vms** | **List&lt;string&gt;** | Identifiers of virtual machines that can match the filter  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; or empty, virtual machines with any identifier matches the filter  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;VirtualMachine&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;VirtualMachine&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

