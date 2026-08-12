# Vcenter.ViJson.OpenApi.Model.ComplianceFailure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FailureType** | **string** | String uniquely identifying the failure.  | 
**Message** | [**LocalizableMessage**](LocalizableMessage.md) | Message which describes the compliance failures message.key serves as a key to the localized message catalog.  | 
**ExpressionName** | **string** | Name of the Expression which generated the ComplianceFailure  | [optional] 
**FailureValues** | [**List&lt;ComplianceFailureComplianceFailureValues&gt;**](ComplianceFailureComplianceFailureValues.md) | If complianceStatus is non-compliant, failureValues will contain values of the non-compliant fields on the host and in the profile.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

