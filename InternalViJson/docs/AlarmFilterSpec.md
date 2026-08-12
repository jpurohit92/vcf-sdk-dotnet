# Vcenter.ViJson.OpenApi.Model.AlarmFilterSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | [**List&lt;ManagedEntityStatusEnum&gt;**](ManagedEntityStatusEnum.md) | Status array which could be used to filter alarms according to their triggered state.  If all triggered alarms need to be matched an empty array or ManagedEntity::red and ManagedEntity::yellow could be filled in the array.  | [optional] 
**TypeEntity** | **string** | Use values from *AlarmFilterSpecAlarmTypeByEntity_enum*  | [optional] 
**TypeTrigger** | **string** | Use values from *AlarmFilterSpecAlarmTypeByTrigger_enum*  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

