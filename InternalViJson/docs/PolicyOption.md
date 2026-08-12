# Vcenter.ViJson.OpenApi.Model.PolicyOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifier for the policy option.  This value matches one of the keys from the list of possible options in the policy metadata (*ProfilePolicyMetadata*.*ProfilePolicyMetadata.possibleOption*\\[\\].*ProfilePolicyOptionMetadata.id*.*ElementDescription.key*).  | 
**Parameter** | [**List&lt;KeyAnyValue&gt;**](KeyAnyValue.md) | Parameters for the policy option.  This list must include all parameters that are not marked as optional in the policy option metadata parameter list (*ProfilePolicyMetadata*.*ProfilePolicyMetadata.possibleOption*\\[\\].*ProfilePolicyOptionMetadata.parameter*\\[\\].*ProfileParameterMetadata.optional*).  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

