# Vcenter.ViJson.OpenApi.Model.QueryEventsRequestType
The parameters of *EventManager.QueryEvents*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Filter** | [**EventFilterSpec**](EventFilterSpec.md) | Defines a filtering criteria for the event query.  | 
**EventViewSpec** | [**EventManagerEventViewSpec**](EventManagerEventViewSpec.md) | Defines the view parameters for the event query.  To retrieve the newest events in the system, use 2147480000 (or the value of \&quot;config.vpxd.event.maxEventId\&quot; advanced vCenter configuration option) as *EventManagerViewByStartId.startEventId* and set *EventManagerViewByStartId.isForward* to false. To retrieve subsequent pages of results with older events, use the smallest event ID from the previous response as the *EventManagerViewByStartId.startEventId* and set*EventManagerViewByStartId.isForward* to false in the next query. To retrieve subsequent pages of results with newer events, use the biggest event ID from the previous page as the *EventManagerViewByStartId.startEventId* and set *EventManagerViewByStartId.isForward* to true in the next query.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

