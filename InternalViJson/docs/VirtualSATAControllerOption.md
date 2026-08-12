# Vcenter.ViJson.OpenApi.Model.VirtualSATAControllerOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Devices** | [**IntOption**](IntOption.md) | The minimum and maximum number of devices this controller can control at run time.  | 
**SupportedDevice** | **List&lt;string&gt;** | Array of supported device options for this controller.  | [optional] 
**NumSATADisks** | [**IntOption**](IntOption.md) | Three properties (numSATADisks.min, numSATADisks.max, and numSATADisks.defaultValue) define the minimum, maximum, and default number of SATA VirtualDisk instances available at any given time in the SATA controller.  The number of SATA VirtualDisk instances is also limited by the number of available slots in the SATA controller.  | 
**NumSATACdroms** | [**IntOption**](IntOption.md) | Three properties (numSATACdroms.min, numSATACdroms.max, and numSATACdroms.defaultValue) define the minimum, maximum, and default number of SATA VirtualCdrom instances available in the SATA controller.  The number of SATA VirtualCdrom instances is also limited by the number of available slots in the SATA controller.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

