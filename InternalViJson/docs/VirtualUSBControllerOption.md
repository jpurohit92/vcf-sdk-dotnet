# Vcenter.ViJson.OpenApi.Model.VirtualUSBControllerOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Devices** | [**IntOption**](IntOption.md) | The minimum and maximum number of devices this controller can control at run time.  | 
**SupportedDevice** | **List&lt;string&gt;** | Array of supported device options for this controller.  | [optional] 
**AutoConnectDevices** | [**BoolOption**](BoolOption.md) | Flag to indicate whether or not the ability to autoconnect devices is enabled for this virtual USB controller.  | 
**EhciSupported** | [**BoolOption**](BoolOption.md) | Flag to indicate whether or not enhanced host controller interface (USB 2.0) is available on this virtual USB controller.  | 
**SupportedSpeeds** | **List&lt;string&gt;** | Range of USB device speeds supported by this USB controller type.  Acceptable values are specified at *VirtualMachineUsbInfoSpeed_enum*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

