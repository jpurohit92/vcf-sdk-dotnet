# Vcenter.ViJson.OpenApi.Model.CompositePolicyOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifier for the policy option.  This value matches one of the keys from the list of possible options in the policy metadata (*ProfilePolicyMetadata*.*ProfilePolicyMetadata.possibleOption*\\[\\].*ProfilePolicyOptionMetadata.id*.*ElementDescription.key*).  | 
**Parameter** | [**List&lt;KeyAnyValue&gt;**](KeyAnyValue.md) | Parameters for the policy option.  This list must include all parameters that are not marked as optional in the policy option metadata parameter list (*ProfilePolicyMetadata*.*ProfilePolicyMetadata.possibleOption*\\[\\].*ProfilePolicyOptionMetadata.parameter*\\[\\].*ProfileParameterMetadata.optional*).  | [optional] 
**Option** | [**List&lt;PolicyOption&gt;**](PolicyOption.md) | List of policy options that are composed and applicable for this composite policy option.  The selected PolicyOptions in a CompositePolicyOption will be used in the policy. PolicyOptions need not be specified if they are not desired for the CompositePolicyOption. Order of PolicyOptions in the PolicyOption array is not significant. The host profile policy engine will not respect order of PolicyOptions. It will apply PolicyOptions in a pre-determined order. Clients of the API must produce PolicyOption in the same order as specified in the metadata.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

