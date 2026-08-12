# Vcenter.ViJson.OpenApi.Model.PbmComplianceStatusEnum
The *PbmComplianceStatus_enum* enumeration type defines the set of status values for compliance operations.  See *PbmComplianceResult* and *PbmRollupComplianceResult*.  Possible values: - `compliant`: Entity is in compliance. - `nonCompliant`: Entity is out of compliance. - `unknown`: Compliance status of the entity is not known. - `notApplicable`: Compliance computation is not applicable for this entity,   because it does not have any storage requirements that   apply to the object-based datastore on which this entity is placed. - `outOfDate`: This is the same as *PbmComplianceResult.mismatch*   variable.      Compliance status becomes out-of-date when the profile   associated with the entity is edited and not applied. The compliance   status will remain in out-of-date compliance status until the latest   policy is applied to the entity. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

