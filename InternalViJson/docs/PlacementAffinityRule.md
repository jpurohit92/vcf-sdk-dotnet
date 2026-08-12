# Vcenter.ViJson.OpenApi.Model.PlacementAffinityRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleType** | **string** | Type of affinity rule.  The set of possible values are described in *PlacementAffinityRuleRuleType_enum*  | 
**RuleScope** | **string** | Scope of the affinity rule.  The set of possible values are described in *PlacementAffinityRuleRuleScope_enum*  | 
**Vms** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | List of virtual machines that are part of this rule.  Refers instances of *VirtualMachine*.  | [optional] 
**Keys** | **List&lt;string&gt;** | List of PlacementSpec keys that are part of this rule representing virtual machines yet to be placed.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

