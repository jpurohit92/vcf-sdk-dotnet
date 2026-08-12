# Vcenter.ViJson.OpenApi.Model.DpuStatusInfoOperationalInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SensorId** | **string** | This string uniquely identifies a sensor in the DPU.  | 
**HealthState** | [**ElementDescription**](ElementDescription.md) | The health state of the element indicated by the sensor.  See also *HostNumericSensorHealthState_enum*.  | [optional] 
**Reading** | **string** | A description of the state of the sensor such as: N watts, Y RPM, or other measurement.  | 
**Units** | **string** | If provided by underlying API, the base units in which the sensor reading is specified, \&quot;RPM\&quot;, \&quot;WATTS\&quot; and so forth.  | [optional] 
**TimeStamp** | **DateTime** | Reports the ISO 8601 Timestamp when this sensor was last updated by management controller if the this sensor is capable of tracking when it was last updated.  Property timeStampRaw, which comes from vendor firmware is convertible to DateTime, it will be provided.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

