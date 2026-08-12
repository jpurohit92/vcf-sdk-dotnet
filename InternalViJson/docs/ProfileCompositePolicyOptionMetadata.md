# Vcenter.ViJson.OpenApi.Model.ProfileCompositePolicyOptionMetadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ExtendedElementDescription**](ExtendedElementDescription.md) | Identifier for the policy option. - The &lt;code&gt;id.key&lt;/code&gt; value   (*ExtendedElementDescription*.*ElementDescription.key*)   identifies the policy option type. - The &lt;code&gt;id.label&lt;/code&gt; property   (*ExtendedElementDescription*.*Description.label*)   contains a brief localizable message describing the policy option. - The &lt;code&gt;id.summary&lt;/code&gt; property   (*ExtendedElementDescription*.*Description.summary*)   contains a localizable summary of the policy option.   Summary information can contain embedded variable names which can   be replaced with values from the &lt;code&gt;parameter&lt;/code&gt; property.  | 
**Parameter** | [**List&lt;ProfileParameterMetadata&gt;**](ProfileParameterMetadata.md) | Metadata about the parameters for the policy option.  | [optional] 
**Option** | **List&lt;string&gt;** | List of optional policy option identifiers that could be combined in this composite policy option.  The policy options should already be part of the possible policy options for the policy. See the *ProfilePolicyMetadata*.*ProfilePolicyMetadata.possibleOption* list.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

