# Vcenter.ViJson.OpenApi.Model.VirtualSerialPortDeviceBackingInfo
The <code>*VirtualSerialPortDeviceBackingInfo*</code> data object defines information for using a host serial port device as backing for a <code>*VirtualSerialPort*</code>.  On a host, the first virtual machine to configure physical device backing for a virtual serial port will obtain the mapping. As long as that machine maintains the backing, any additional attempts to configure backing using that device will fail (a recoverable error, see the connection info <code>*VirtualDeviceConnectInfo.status*</code>). 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceName** | **string** | The name of the device on the host system.  | 
**UseAutoDetect** | **bool** | Indicates whether the device should be auto detected instead of directly specified.  If this value is set to TRUE, deviceName is ignored.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

