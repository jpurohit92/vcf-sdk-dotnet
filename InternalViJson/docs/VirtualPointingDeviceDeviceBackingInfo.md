# Vcenter.ViJson.OpenApi.Model.VirtualPointingDeviceDeviceBackingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceName** | **string** | The name of the device on the host system.  | 
**UseAutoDetect** | **bool** | Indicates whether the device should be auto detected instead of directly specified.  If this value is set to TRUE, deviceName is ignored.  | [optional] 
**HostPointingDevice** | **string** | This optional property defines the mouse type (two-button, three-button, and so on).  The mouse type determines how the user interacts with the host mouse. The valid values are specified in the *VirtualPointingDeviceHostChoice_enum* list.  **Note**: The value specified by this property must be one of the supported types listed in the hostPointingDevices.value array in the *VirtualPointingDeviceOption* data object type. If this property is not set, then the property defaults to the hostPointingDevices.defaultIndex property in the same data object type.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

