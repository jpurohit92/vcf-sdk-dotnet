# Vcenter.ViJson.OpenApi.Model.OrAlarmExpression

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Expression** | [**List&lt;AlarmExpression&gt;**](AlarmExpression.md) | List of alarm expressions that define the overall status of the alarm. - The state of the alarm expression is gray if all subexpressions are gray.   Otherwise, gray subexpressions are ignored. - The state is red if any subexpression is red. - Otherwise, the state is yellow if any subexpression is yellow. - Otherwise, the state of the alarm expression is green.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

