# Vcenter.ViJson.OpenApi.Model.LicenseAssignmentManagerLicenseAssignment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityId** | **string** | Id for the entity  | 
**Scope** | **string** | Scope of the entityId  | [optional] 
**EntityDisplayName** | **string** | Display name of the entity  | [optional] 
**AssignedLicense** | [**LicenseManagerLicenseInfo**](LicenseManagerLicenseInfo.md) | License assigned to the entity  | 
**Properties** | [**List&lt;KeyAnyValue&gt;**](KeyAnyValue.md) | Additional properties associated with this assignment Some of the properties are: \&quot;inUseFeatures\&quot; - - Features in the license key that are being used by the entity \&quot;ProductName\&quot; - - Name of the entity.  Should match the product name of the assigned license. \&quot;ProductVersion\&quot; - - Version of the entity. Should match the product version of the assigned license. \&quot;Evaluation\&quot; - - EvaluationInfo object representing the evaluation left for the entity.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

