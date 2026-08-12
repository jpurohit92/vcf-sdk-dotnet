# Vcenter.ViJson.OpenApi.Model.VirtualPS2ControllerOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Devices** | [**IntOption**](IntOption.md) | The minimum and maximum number of devices this controller can control at run time.  | 
**SupportedDevice** | **List&lt;string&gt;** | Array of supported device options for this controller.  | [optional] 
**NumKeyboards** | [**IntOption**](IntOption.md) | The minimum, maximum, and default number of keyboards you can have at any given time.  This is further constrained by the number of available slots in the PS/2 controller. The minimum, maximum, and default are integers defined by three properties: - **numKeyBoards.min**: the minimum. - **numKeyBoards.max**: the maximum. - **numKeyBoards.defaultValue**: the default number.  | 
**NumPointingDevices** | [**IntOption**](IntOption.md) | The minimum, maximum, and default number of mice you can have at any given time.  The number of mice is also limited by the number of available slots in the PS/2 controller. The minimum, maximum, and default are integers defined by three properties: - **numPointingDevices.min**: the minimum. - **numPointingDevices.max**: the maximum. - **numPointingDevices.defaultValue**: the default number.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

