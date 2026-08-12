# Vcenter.ViJson.OpenApi.Model.DisableAlarmRequestType
The parameters of *AlarmManager.DisableAlarm*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alarm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The Alarm being disabled.  ***Required privileges:*** Alarm.ToggleEnableOnEntity  Refers instance of *Alarm*.  | 
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The ManagedEntity on which to disable the alarm.  ***Required privileges:*** System.Read  Refers instance of *ManagedEntity*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

