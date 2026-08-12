# Vcenter.ViJson.OpenApi.Model.VirtualPCIPassthroughDvxBackingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceClass** | **string** | The device class that backs this DVX device.  During add operations, this value must be a non-empty string. During edit operations, if this value is not set or is an empty string, the current device class remains unchanged.  | [optional] 
**ConfigParams** | [**List&lt;OptionValue&gt;**](OptionValue.md) | The configuration parameters for this device class.  All required configuration parameters must be provided for both add and edit operations. The provided configuration parameters replace the previous ones. In particular, passing an empty array will unset all existing configuration parameters.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

