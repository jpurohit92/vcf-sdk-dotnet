# Vcenter.ViJson.OpenApi.Model.AlarmFilter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AlarmStatus** | **string** | The status of the alarm to search for.  Should be one of *SmsAlarmStatus_enum*. If not specified, all status values should be considered.  | [optional] 
**AlarmType** | **string** | The status of the alarm to search for.  Should be one of *AlarmType_enum*. If not specified, all alarm types should be considered.  | [optional] 
**EntityType** | **string** | The entityType of interest, VASA provider should return all active alarms of this type when *AlarmFilter.entityId* is not set.  See *SmsEntityType_enum*.  | [optional] 
**EntityId** | [**List&lt;Any&gt;**](Any.md) | The identifiers of the entities of interest.  If set, all entities must be of the same *SmsEntityType_enum* and it should be set in *AlarmFilter.entityType*. VASA provider can skip listing the missing entities.  | [optional] 
**PageMarker** | **string** | The page marker used for query pagination.  This is an opaque string that will be set based on the value returned by the VASA provider - see *AlarmResult.pageMarker*. For initial request this should be set to null, indicating request for the first page.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

