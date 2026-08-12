# Vcenter.ViJson.OpenApi.Model.HostNumericSensorInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the physical element associated with the sensor It consists of a string of the form: \&quot;description - -- state/identifer\&quot;.  | 
**HealthState** | [**ElementDescription**](ElementDescription.md) | The health state of the of the element indicated by the sensor.  This property is populated only for sensors that support threshold settings and for discrete sensors using control file.  See also *HostNumericSensorHealthState_enum*.  | [optional] 
**CurrentReading** | **long** | The current reading of the element indicated by the sensor.  The actual sensor reading is obtained by multiplying the current reading by the scale factor.  | 
**UnitModifier** | **int** | The unit multiplier for the values returned by the sensor.  All values returned by the sensor are current reading \\* 10 raised to the power of the UnitModifier. If no unitModifier applies the value returned is 0.  | 
**BaseUnits** | **string** | The base units in which the sensor reading is specified.  If rateUnits is set the units of the current reading is further qualified by the rateUnits. Otherwise the value returned is &#39;unspecified&#39;.  See also *HostNumericSensorInfo.rateUnits*.  | 
**RateUnits** | **string** | The rate units in which the sensor reading is specified.  For example if the baseUnits is Volts and the rateUnits is per second the value returned by the sensor are in Volts/second. If no rate applies the value returned is &#39;none&#39;.  | [optional] 
**SensorType** | **string** | The type of the sensor.  If the sensor type is set to Other the sensor name can be used to further identify the type of sensor. The sensor units can also be used to further implicitly determine the type of the sensor.  See also *HostNumericSensorType_enum*.  | 
**Id** | **string** | A unique sensor identifier.  A four part value consisting of: BMC device.Entity ID.Instance.SensorNumber Can be used to match a NumericSensorInfo object to esxcli hardware ipmi sdr list  | [optional] 
**SensorNumber** | **long** | The IPMI Sensor/probe that is reporting this event.  Use this value to locate System Event Log (SEL) entries for this Sensor. It is also reported in &#39;id&#39; in string format. This property is intended to be used with vim.host.SystemEventInfo.sensorNumber  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**TimeStamp** | **string** | Reports the ISO 8601 Timestamp when this sensor was last updated by management controller if the this sensor is capable of tracking when it was last updated.  | [optional] 
**Fru** | [**HostFru**](HostFru.md) | The FRU this sensor monitors if any.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

