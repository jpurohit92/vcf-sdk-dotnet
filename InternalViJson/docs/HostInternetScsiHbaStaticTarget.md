# Vcenter.ViJson.OpenApi.Model.HostInternetScsiHbaStaticTarget

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | The IP address or hostname of the storage device.  | 
**Port** | **int** | The TCP port of the storage device.  If not specified, the standard default of 3260 is used.  | [optional] 
**IScsiName** | **string** | The iSCSI name of the storage device.  | 
**DiscoveryMethod** | **string** | Discovery method each static target is discovered by some method define in TargetDiscoveryMethod.  | [optional] 
**AuthenticationProperties** | [**HostInternetScsiHbaAuthenticationProperties**](HostInternetScsiHbaAuthenticationProperties.md) | The authentication settings for this target.  | [optional] 
**DigestProperties** | [**HostInternetScsiHbaDigestProperties**](HostInternetScsiHbaDigestProperties.md) | The digest settings for this target.  | [optional] 
**SupportedAdvancedOptions** | [**List&lt;OptionDef&gt;**](OptionDef.md) | A list of supported key/value pair advanced options for the host bus adapter including their type information.  | [optional] 
**AdvancedOptions** | [**List&lt;HostInternetScsiHbaParamValue&gt;**](HostInternetScsiHbaParamValue.md) | A list of the current options settings for the host bus adapter.  | [optional] 
**Parent** | **string** | The parent entity from which settings can be inherited.  It can either be unset, or set to the device name of the host bus adapter or the name of the SendTarget.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

