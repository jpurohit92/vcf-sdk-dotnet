# Vcenter.ViJson.OpenApi.Model.DvsTrafficRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key of the rule  | [optional] 
**Description** | **string** | Description of the rule  | [optional] 
**Sequence** | **int** | Sequence of this rule.  i.e, the order in which this rule appears in the ruleset.  | [optional] 
**Qualifier** | [**List&lt;DvsNetworkRuleQualifier&gt;**](DvsNetworkRuleQualifier.md) | List of Network rule qualifiers.  &#39;AND&#39; of this array of network rule qualifiers is applied as one network traffic rule. If the TrafficRule belongs to *DvsFilterPolicy* : There can be a maximum of 1 *DvsIpNetworkRuleQualifier*, 1 *DvsMacNetworkRuleQualifier* and 1 *DvsSystemTrafficNetworkRuleQualifier* for a total of 3 *DvsTrafficRule.qualifier*  | [optional] 
**Action** | [**DvsNetworkRuleAction**](DvsNetworkRuleAction.md) | Action to be applied for this rule.  | [optional] 
**Direction** | **string** | Whether this rule needs to be applied to incoming packets, to outgoing packets or both.  See *DvsNetworkRuleDirectionType_enum* for valid values.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

