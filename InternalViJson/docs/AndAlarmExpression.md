# Vcenter.ViJson.OpenApi.Model.AndAlarmExpression

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Expression** | [**List&lt;AlarmExpression&gt;**](AlarmExpression.md) | List of alarm expressions that define the overall status of the alarm. - The state of the alarm expression is gray if all subexpressions are gray.   Otherwise, gray subexpressions are ignored. - The state is red if all subexpressions are red. - Otherwise, the state is yellow if all subexpressions are red or yellow. - Otherwise, the state of the alarm expression is green.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

