# Vcenter.ViJson.OpenApi.Model.VirtualSIOControllerOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Devices** | [**IntOption**](IntOption.md) | The minimum and maximum number of devices this controller can control at run time.  | 
**SupportedDevice** | **List&lt;string&gt;** | Array of supported device options for this controller.  | [optional] 
**NumFloppyDrives** | [**IntOption**](IntOption.md) | Three properties (numFloppyDrives.min, numFloppyDrives.max, and numFloppyDrives.defaultValue) define the minimum, maximum, and default number of floppy drives you can have at any given time in the Super IO Controller.  This is further constrained by the number of available slots in the Super IO Controller.  | 
**NumSerialPorts** | [**IntOption**](IntOption.md) | Three properties (numSerialPorts.min, numSerialPorts.max, and numSerialPorts.defaultValue) define the minimum, maximum, and default number of serial ports you can have at any given time in the Super IO Controller.  This is further constrained by the number of available slots in the Super IO Controller.  | 
**NumParallelPorts** | [**IntOption**](IntOption.md) | Three properties (numParallelPorts.min, numParallelPorts.max, and numParallelPorts.defaultValue) define the minimum, maximum, and default number of parallel ports you can have at any given time in the Super IO controller.  This is further constrained by the number of available slots in the Super IO Controller.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

