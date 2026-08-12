# Vcenter.ViJson.OpenApi.Model.EventManagerViewByStartId

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartEventId** | **int** | An integer value specifying the ID of the event from which to start the query.  Must be &amp;gt;&#x3D; 0. The maximum event ID is defined by \&quot;config.vpxd.event.maxEventId\&quot; advanced vCenter configuration option which has a default value of 2147480000.  | 
**IsForward** | **bool** | A boolean flag indicating the direction of the query.  If &lt;code&gt;true&lt;/code&gt;, the query retrieves events with IDs greater than startEventId, representing newer events. If &lt;code&gt;false&lt;/code&gt;, the query retrieves events with IDs less than startEventId, representing older events.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

