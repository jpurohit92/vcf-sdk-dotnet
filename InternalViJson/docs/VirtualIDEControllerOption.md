# Vcenter.ViJson.OpenApi.Model.VirtualIDEControllerOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Devices** | [**IntOption**](IntOption.md) | The minimum and maximum number of devices this controller can control at run time.  | 
**SupportedDevice** | **List&lt;string&gt;** | Array of supported device options for this controller.  | [optional] 
**NumIDEDisks** | [**IntOption**](IntOption.md) | The minimum, maximum, and default number of IDE VirtualDisk instances you can have, at any given time, in the IDE controller.  The number is further constrained by the number of available slots in the virtual IDE controller.  | 
**NumIDECdroms** | [**IntOption**](IntOption.md) | The minimum, maximum, and default number of IDE VirtualCdrom instances you can have, at any given time, in the IDE controller.  The number is further constrained by the number of available slots in the virtual IDE controller.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

