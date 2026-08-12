# Vcenter.ViJson.OpenApi.Model.SystemEventInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecordId** | **long** | The recordId uniquely identifies an entry in IPMI System Event Log.  | 
**When** | **string** | A ISO 8601 timestamp when the event was added to IPMI System Event Log.  This timestamp comes from the IPMI subsystem clock and may not be the same as hypervisor&#39;s clock.  | 
**SelType** | **long** | The IPMI SEL type defines the if the SEL event uses the system event format format or is OEM defined.  A value of 2 indicates system event. Values 0xC0-0xDF, 0xE0-0xFF are OEM event ranges.  | 
**Message** | **string** | A description of what the event is about.  | 
**SensorNumber** | **long** | The IPMI Sensor/probe that is reporting this event.  A value of zero (0) indicates event has no related sensor.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

