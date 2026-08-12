# Vcenter.ViJson.OpenApi.Model.SearchIndexPredicateArrayOperatorEnum
Possible values: - `AllElements`: When specified, the value on the right hand side   (*SearchIndexPredicate.comparableValue*) is compared   against each element in the array with the provided operator   *SearchIndexPredicateComparisonOperator_enum*.      The resource will be matched if the *SearchIndexPredicateComparisonOperator_enum*   returns true for ALL elements in the array, otherwise it will   be filtered out. - `AnyElement`: When specified, the value on the right hand side   (*SearchIndexPredicate.comparableValue*) is compared   against each element in the array with the provided operator   *SearchIndexPredicateComparisonOperator_enum*.      The resource will be matched if the *SearchIndexPredicateComparisonOperator_enum*   returns true for ANY element in the array, otherwise it will   be filtered out. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

