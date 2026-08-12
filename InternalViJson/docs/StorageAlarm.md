# Vcenter.ViJson.OpenApi.Model.StorageAlarm

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AlarmId** | **long** | Monotonically increasing sequence number which VP will maintain.  | 
**AlarmType** | **string** | The type of Alarm.  Must be one of the string values from *AlarmType_enum* Note that for VMODL VP implementation this field must be populated with one of the values from &#x60;vasa.data.notification.AlarmType&#x60;  | 
**ContainerId** | **string** | Container identifier  | [optional] 
**ObjectId** | **string** | The unique identifier of the object impacted by the Alarm.  From VASA version 3 onwards, a non-null *StorageAlarm.alarmObject* will override this member. This field is made optional from VASA3. Either this or *StorageAlarm.alarmObject* must be set.  | [optional] 
**ObjectType** | **string** | The type of object impacted by the Alarm.  Must be one of the string values from *SmsEntityType_enum* Note that for VMODL VP implementation this field must be populated with one of the values from &#x60;vasa.data.notification.EntityType&#x60;  | 
**Status** | **string** | Current status of the object.  Must be one of the string values from *SmsAlarmStatus_enum*  | 
**AlarmTimeStamp** | **DateTime** | Time-stamp when the alarm occurred in VP context  | 
**MessageId** | **string** | Pre-defined message for system-defined event  | 
**ParameterList** | [**List&lt;NameValuePair&gt;**](NameValuePair.md) | List of parameters (name/value) to be passed as input for message  | [optional] 
**AlarmObject** | [**Any**](Any.md) | The ID of the object on which the alarm is raised; this is an object, since ID&#39;s may not always be strings.  vSphere will first use *StorageAlarm.alarmObject* if set, and if not uses *StorageAlarm.objectId*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

