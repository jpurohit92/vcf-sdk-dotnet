# Vcenter.ViJson.OpenApi.Model.VirtualPointingDeviceBackingOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoDetectAvailable** | [**BoolOption**](BoolOption.md) | Flag to indicate whether the specific instance of this device can be auto-detected on the host instead of having to specify a particular physical device.  | 
**HostPointingDevice** | [**ChoiceOption**](ChoiceOption.md) | This object defines the supported mouse types, including the default supported mouse type, with the following properties: - **hostPointingDevices.value**: This array defines the   supported mouse types. - **hostPointingDevices.choiceDescription**: This array   provides the descriptions for the supported mouse types defined by   hostPointingDevices.value. - **hostPointingDevices.defaultIndex**: This integer points   to an index in the hostPointingDevices.value array. This is the   mouse type supported by default.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

