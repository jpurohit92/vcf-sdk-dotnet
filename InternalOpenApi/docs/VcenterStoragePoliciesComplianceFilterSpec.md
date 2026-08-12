# Vcenter.Automation.OpenApi.Model.VcenterStoragePoliciesComplianceFilterSpec
The Vcenter.Storage.Policies.Compliance.FilterSpec schema contains complianceStatus used to filter the results when listing entities (see *GET /vcenter/storage/policies/entities/compliance*).  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **List&lt;string&gt;** | Compliance Status that a virtual machine must have to match the filter.  Possible values:   - &#x60;COMPLIANT&#x60;: Entity is in compliance.   - &#x60;NON_COMPLIANT&#x60;: Entity is out of compliance.   - &#x60;UNKNOWN&#x60;: Compliance status of the entity is not known.   - &#x60;NOT_APPLICABLE&#x60;: Compliance computation is not applicable for this entity because it does not have any storage requirement that apply to the object-based datastore on which the entity is placed.   - &#x60;OUT_OF_DATE&#x60;: Compliance status becomes out of date when the profile associated with the entity is edited and not applied. The compliance status will remain out of date until the latest policy is applied to the entity.   For more information see: *Vcenter.Storage.Policies.Compliance.Status*.  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

