# Vcenter.ViJson.OpenApi.Model.PbmCapabilityProfileCreateSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the capability based profile to be created.  The maximum length of the name is 80 characters.  | 
**Description** | **string** | Text description associated with the profile.  | [optional] 
**Category** | **string** | Category specifies the type of policy to be created.  This can be REQUIREMENT from *PbmProfileCategoryEnum_enum* or null when creating a storage policy. And it can be DATA\\_SERVICE\\_POLICY from *PbmProfileCategoryEnum_enum* when creating a data service policy. RESOURCE from *PbmProfileCategoryEnum_enum* is not allowed as resource profile is created by the system.  | [optional] 
**ResourceType** | [**PbmProfileResourceType**](PbmProfileResourceType.md) | Deprecated as of vSphere API 6.5.  Specifies the type of resource to which the profile applies.  The only legal value is STORAGE - deprecated.  | 
**Constraints** | [**PbmCapabilityConstraints**](PbmCapabilityConstraints.md) | Set of subprofiles that define the storage requirements.  A subprofile corresponds to a rule set in the vSphere Web Client.  | 
**K8sCompliantName** | **string** | Indicates compliant name to be used as K8s &#x60;StorageClass&#x60; name when this policy is used for K8s workloads.  If compliant name is specified, and it&#39;s not RFC 1123 compliant, then policy creation would fail. Duplicating the compliant name across storage profiles in a vCenter is not allowed. If either there is already a K8s &#x60;StorageClass&#x60; with this name or WaitForForFirstConsumer &#x60;StorageClass&#x60; with the name &#39;*PbmCapabilityProfileCreateSpec.k8sCompliantName*-latebinding&#39;, then the policy creation would fail. Compliant name will automatically be generated and populated based on policy name if it&#39;s not provided.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

