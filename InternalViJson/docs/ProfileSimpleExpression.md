# Vcenter.ViJson.OpenApi.Model.ProfileSimpleExpression

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifier of this expression.  The id has to be unique within a Profile. The id can be used as a key while building composite expressions.  | 
**DisplayName** | **string** | User visible display name  | 
**Negated** | **bool** | Flag indicating if the condition of the expression should be negated.  e.g: conditions like VSwitch0 has vmnic0 connected to it can be turned into VSwitch0 doesn&#39;t have vmnic0 connected to it.  | 
**ExpressionType** | **string** | Type of the simple expression to instantiate.  The expressionType should be derived from the available expressions as listed in the metadata.  | 
**Parameter** | [**List&lt;KeyAnyValue&gt;**](KeyAnyValue.md) | The parameters for the expressionType.  The list of parameters needed for a simple expression can be obtained from the metadata.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

