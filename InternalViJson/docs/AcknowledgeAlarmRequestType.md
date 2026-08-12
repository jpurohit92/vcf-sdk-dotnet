# Vcenter.ViJson.OpenApi.Model.AcknowledgeAlarmRequestType
The parameters of *AlarmManager.AcknowledgeAlarm*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alarm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The Alarm to acknowledge.  ***Required privileges:*** Alarm.Acknowledge  Refers instance of *Alarm*.  | 
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The ManagedEntity for which to acknowledge the Alarm.  ***Required privileges:*** System.Read  Refers instance of *ManagedEntity*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

