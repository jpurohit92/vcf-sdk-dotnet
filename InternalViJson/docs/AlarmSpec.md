# Vcenter.ViJson.OpenApi.Model.AlarmSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the alarm.  | 
**SystemName** | **string** | System name of the alarm.  This is set only for predefined Alarms - i.e. Alarms created by the server or extensions automatically. After creation this value cannot be modified. User-created Alarms do not have a systemName at all.  The purpose of this field is to identify system-created Alarms reliably, even if they are edited by users.  When creating Alarms with systemName, the systemName and the name of the alarm should be equal.  When reconfiguring an Alarm with systemName, the same systemName should be passed in the new AlarmSpec. Renaming Alarms with systemName is not allowed, i.e. when reconfiguring, the name passed in the new AlarmSpec should be equal to either the systemName or its localized version (the current name in the Alarm&#39;s info).  | [optional] 
**Description** | **string** | Description of the alarm.  | 
**Enabled** | **bool** | Flag to indicate whether or not the alarm is enabled or disabled.  | 
**Expression** | [**AlarmExpression**](AlarmExpression.md) | Top-level alarm expression that defines trigger conditions.  | 
**Action** | [**AlarmAction**](AlarmAction.md) | Action to perform when the alarm is triggered.  | [optional] 
**ActionFrequency** | **int** | Frequency in seconds, which specifies how often appropriate actions should repeat when an alarm does not change state.  | [optional] 
**Setting** | [**AlarmSetting**](AlarmSetting.md) | Tolerance and maximum frequency settings.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

