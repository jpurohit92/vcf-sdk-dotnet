# Vcenter.Automation.OpenApi.Model.VcenterVmStoragePolicyComplianceStatus
The Vcenter.Vm.Storage.Policy.Compliance.Status enumerated type defines the storage compliance status of a virtual machine and its applicable entities.  Possible values:   - `COMPLIANT`: Entity is in compliance.   - `NON_COMPLIANT`: Entity is out of compliance.   - `UNKNOWN_COMPLIANCE`: Compliance status of the entity is not known.   - `NOT_APPLICABLE`: Compliance computation is not applicable for this entity because it does not have any storage requirements that apply to the datastore on which it is placed.   - `OUT_OF_DATE`: The Compliance status becomes out-of-date when the profile associated with the entity is edited but not applied. The compliance status remains out-of-date until the edited policy is applied to the entity.   This enumeration was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

