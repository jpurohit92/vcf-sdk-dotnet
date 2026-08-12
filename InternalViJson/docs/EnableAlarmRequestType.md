# Vcenter.ViJson.OpenApi.Model.EnableAlarmRequestType
The parameters of *AlarmManager.EnableAlarm*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alarm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The Alarm being enabled.  ***Required privileges:*** Alarm.ToggleEnableOnEntity  Refers instance of *Alarm*.  | 
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The ManagedEntity on which to enable the alarm.  ***Required privileges:*** System.Read  Refers instance of *ManagedEntity*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

