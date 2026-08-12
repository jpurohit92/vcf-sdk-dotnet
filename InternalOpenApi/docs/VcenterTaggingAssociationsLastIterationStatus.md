# Vcenter.Automation.OpenApi.Model.VcenterTaggingAssociationsLastIterationStatus
The last status for the iterator. A field of this type is returned as part of the result and indicates to the caller of the API whether it can continue to make requests for more data.    The last status only reports on the state of the iteration at the time data was last returned. As a result, it not does guarantee if the next call will succeed in getting more data or not.    Failures to retrieve results will be returned as Error responses. These last statuses are only returned when the iterator is operating as expected.  Possible values:   - `READY`: Iterator has more data pending and is ready to provide it. The caller can request the next page of data at any time.    The number of results returned may be less than the usual size. In other words, the iterator may not fill the page. The iterator has returned at least 1 result.   - `END_OF_DATA`: Iterator has finished iterating through its inventory. There are currently no more entities to return and the caller can terminate iteration. If the iterator returned some data, the marker may be set to allow the iterator to continue from where it left off when additional data does become available. This value is used to indicate that all available data has been returned by the iterator.   This enumeration was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

