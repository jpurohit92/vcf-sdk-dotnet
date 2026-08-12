# Vcenter.ViJson.OpenApi.Model.ProfileCompositeExpression

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifier of this expression.  The id has to be unique within a Profile. The id can be used as a key while building composite expressions.  | 
**DisplayName** | **string** | User visible display name  | 
**Negated** | **bool** | Flag indicating if the condition of the expression should be negated.  e.g: conditions like VSwitch0 has vmnic0 connected to it can be turned into VSwitch0 doesn&#39;t have vmnic0 connected to it.  | 
**Operator** | **string** | Logical operator to be applied between the expressions in the composite expression.  e.g: or, and  | 
**ExpressionName** | **List&lt;string&gt;** | List of expression names that will be used for this composition.  The individual expressions will return a boolean. The return values of the individual expressions will be used to compute the final return value of the CompositeExpression. The expressions specified in the list can themselves be CompositeExpressions.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

