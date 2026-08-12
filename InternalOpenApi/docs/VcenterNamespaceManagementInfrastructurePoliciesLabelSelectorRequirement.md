# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementInfrastructurePoliciesLabelSelectorRequirement
The Vcenter.NamespaceManagement.InfrastructurePolicies.LabelSelectorRequirement schema contains a label selector requirement. The logic between multiple label requirements is AND.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The label key that the selector applies to.  This property was added in __vSphere API 9.1.0.0__. | 
**Operator** | **string** | The operator that relates the key and values.  Possible values:   - &#x60;IS_IN&#x60;: Label key must exist with value in the specified list.   - &#x60;IS_NOT_IN&#x60;: Label key must exist with value not in the specified list.   - &#x60;EXISTS&#x60;: Label key must exist.   - &#x60;DOES_NOT_EXIST&#x60;: Label key must not exist.   For more information see: *Vcenter.NamespaceManagement.InfrastructurePolicies.LabelSelectorOperator*.  This property was added in __vSphere API 9.1.0.0__. | 
**Values** | **List&lt;string&gt;** | An array of string values. If the operator is ValueSelectorOperator#IS_IN or ValueSelectorOperator#IS_NOT_IN, the values array must be non-empty. If the operator is ValueSelectorOperator#EXISTS or ValueSelectorOperator#DOES_NOT_EXIST, the values array must be empty.  This property was added in __vSphere API 9.1.0.0__.  Required for ValueSelectorOperator#IS_IN and ValueSelectorOperator#IS_NOT_IN operators, ignored for others. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

