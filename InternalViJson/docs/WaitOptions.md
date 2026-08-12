# Vcenter.ViJson.OpenApi.Model.WaitOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxWaitSeconds** | **int** | The number of seconds the *PropertyCollector* should wait before returning null.  Returning updates may take longer if the actual calculation time exceeds *WaitOptions.maxWaitSeconds*. Additionally *PropertyCollector* policy may cause it to return null sooner than *WaitOptions.maxWaitSeconds*.  An unset value causes *PropertyCollector.WaitForUpdatesEx* to wait as long as possible for updates. Policy may still cause the *PropertyCollector* to return null at some point.  A value of 0 causes *PropertyCollector.WaitForUpdatesEx* to do one update calculation and return any results. This behavior is similar to *PropertyCollector.CheckForUpdates*.  A positive value causes *PropertyCollector.WaitForUpdatesEx* to return null if no updates are available within the specified number of seconds. The choice of a positive value often depends on the client communication stack. For example it may be helpful to choose a duration shorter than a local HTTP request timeout. Typically it should be no shorter than a few minutes.  A negative value is illegal.  | [optional] 
**MaxObjectUpdates** | **int** | The maximum number of *ObjectUpdate* entries that should be returned in a single result from *PropertyCollector.WaitForUpdatesEx*.  See *UpdateSet.truncated*  An unset value indicates that there is no maximum. In this case *PropertyCollector* policy may still limit the number of objects that appear in an *UpdateSet*.  A positive value causes *PropertyCollector.WaitForUpdatesEx* to suspend the update calculation when the total count of *ObjectUpdate* entries ready to return reaches the specified maximum. *PropertyCollector* policy may still limit the total count to something less than *WaitOptions.maxObjectUpdates*.  A value less than or equal to 0 is illegal.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

