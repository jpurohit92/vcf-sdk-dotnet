# Vcenter.ViJson.OpenApi.Model.RetrieveOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxObjects** | **int** | The maximum number of *ObjectContent* data objects that should be returned in a single result from *PropertyCollector.RetrievePropertiesEx*.  An unset value indicates that there is no maximum. In this case *PropertyCollector* policy may still limit the number of objects. Any remaining objects may be retrieved with *PropertyCollector.ContinueRetrievePropertiesEx*.  A positive value causes *PropertyCollector.RetrievePropertiesEx* to suspend the retrieval when the count of objects reaches the specified maximum. *PropertyCollector* policy may still limit the count to something less than *RetrieveOptions.maxObjects*. Any remaining objects may be retrieved with *PropertyCollector.ContinueRetrievePropertiesEx*.  A value less than or equal to 0 is illegal.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

