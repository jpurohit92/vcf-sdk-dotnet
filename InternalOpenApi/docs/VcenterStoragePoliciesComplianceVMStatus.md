# Vcenter.Automation.OpenApi.Model.VcenterStoragePoliciesComplianceVMStatus
Possible values:   - `COMPLIANT`: The virtual machine or virtual disk is in compliance.   - `NON_COMPLIANT`: The virtual machine or virtual disk is in not in compliance.   - `UNKNOWN_COMPLIANCE`: Compliance status of the virtual machine or virtual disk is not known.   - `NOT_APPLICABLE`: Compliance computation is not applicable for this virtual machine or disk because it does not have any storage requirement that apply to the object-based datastore on which the entity is placed.   - `OUT_OF_DATE`: Compliance status becomes out of date when the profile associated with the virtual machine or disk is edited and not applied. The compliance status will remain out of date until the latest policy is applied.   This enumeration was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

