# Vcenter.Automation.OpenApi.Model.VcenterStoragePoliciesComplianceStatus
This enumeration defines the set of status values for a compliance operation.  Possible values:   - `COMPLIANT`: Entity is in compliance.   - `NON_COMPLIANT`: Entity is out of compliance.   - `UNKNOWN`: Compliance status of the entity is not known.   - `NOT_APPLICABLE`: Compliance computation is not applicable for this entity because it does not have any storage requirement that apply to the object-based datastore on which the entity is placed.   - `OUT_OF_DATE`: Compliance status becomes out of date when the profile associated with the entity is edited and not applied. The compliance status will remain out of date until the latest policy is applied to the entity.   This enumeration was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

