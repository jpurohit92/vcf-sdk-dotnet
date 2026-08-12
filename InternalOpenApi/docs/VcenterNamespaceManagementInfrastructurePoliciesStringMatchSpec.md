# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementInfrastructurePoliciesStringMatchSpec
The Vcenter.NamespaceManagement.InfrastructurePolicies.StringMatchSpec schema contains string matching criteria.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Op** | **string** | The operator that describes the operation performed against the specified value.  Possible values:   - &#x60;IS_EQUAL&#x60;: Operands must match exactly.   - &#x60;IS_NOT_EQUAL&#x60;: Operands must not match.   - &#x60;CONTAINS&#x60;: Operand being compared must contain the other.   - &#x60;DOES_NOT_CONTAIN&#x60;: Operand being compared must not contain the other.   - &#x60;HAS_PREFIX&#x60;: Compared value must have a prefix specified by the operand.   - &#x60;DOES_NOT_HAVE_PREFIX&#x60;: Compared value must not have a prefix specified by the operand.   - &#x60;HAS_SUFFIX&#x60;: Compared value must have a suffix specified by the operand.   - &#x60;DOES_NOT_HAVE_SUFFIX&#x60;: Compared value must not have a suffix specified by the operand.   - &#x60;MATCHES&#x60;: Compared Value must match the regular expression specified by the operand.   - &#x60;DOES_NOT_MATCH&#x60;: Compared Value must not match the regular expression specified by the operand.   For more information see: *Vcenter.NamespaceManagement.InfrastructurePolicies.ValueSelectorOperator*.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, defaults to *Vcenter.NamespaceManagement.InfrastructurePolicies.ValueSelectorOperator.IS_EQUAL*. | [optional] 
**Value** | **string** | The value that describes the subject of the evaluation.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no value matching is performed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

