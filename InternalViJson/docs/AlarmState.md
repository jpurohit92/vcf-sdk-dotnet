# Vcenter.ViJson.OpenApi.Model.AlarmState

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Unique key that identifies the alarm.  | 
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | Entity on which the alarm is instantiated.  Refers instance of *ManagedEntity*.  | 
**Alarm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Alarm object from which the AlarmState object is instantiated.  Refers instance of *Alarm*.  | 
**OverallStatus** | **ManagedEntityStatusEnum** | Overall status of the alarm object.  This is the value of the alarm&#39;s top-level expression. In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Since this property is on a DataObject, an update returned by WaitForUpdatesEx may contain values for this property when some other property on the DataObject changes. If this update is a result of a call to WaitForUpdatesEx with a non-empty version parameter, the value for this property may not be current.  | 
**Time** | **DateTime** | Time the alarm triggered.  | 
**Acknowledged** | **bool** | Flag to indicate if the alarm&#39;s actions have been acknowledged for the associated ManagedEntity.  | [optional] 
**AcknowledgedByUser** | **string** | The user who acknowledged this triggering.  If the triggering has not been acknowledged, then the value is not valid.  | [optional] 
**AcknowledgedTime** | **DateTime** | The time this triggering was acknowledged.  If the triggering has not been acknowledged, then the value is not valid.  | [optional] 
**EventKey** | **int** | Contains the key of the event that has triggered the alarm.  The value is set only for event based alarms. The value is not set for gray or manually reset alarms (via vim.AlarmManager.setAlarmStatus).  | [optional] 
**Disabled** | **bool** | Flag to indicate if the alarm is disabled for the associated ManagedEntity.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

