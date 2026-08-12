# Vcenter.ViJson.OpenApi.Model.HostInternetScsiHbaSendTarget

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | The IP address or hostname of the storage device.  | 
**Port** | **int** | The TCP port of the storage device.  If not specified, the standard default of 3260 is used.  | [optional] 
**AuthenticationProperties** | [**HostInternetScsiHbaAuthenticationProperties**](HostInternetScsiHbaAuthenticationProperties.md) | The authentication settings for this discovery target.  All static targets discovered via this target will inherit the use of these settings unless the static target&#39;s authentication settings are explicitly set.  | [optional] 
**DigestProperties** | [**HostInternetScsiHbaDigestProperties**](HostInternetScsiHbaDigestProperties.md) | The digest settings for this discovery target.  All static targets discovered via this target will inherit the use of these settings unless the static target&#39;s digest settings are explicitly set.  | [optional] 
**SupportedAdvancedOptions** | [**List&lt;OptionDef&gt;**](OptionDef.md) | A list of supported key/value pair advanced options for the host bus adapter including their type information.  | [optional] 
**AdvancedOptions** | [**List&lt;HostInternetScsiHbaParamValue&gt;**](HostInternetScsiHbaParamValue.md) | A list of the current options settings for the host bus adapter.  | [optional] 
**Parent** | **string** | The device name of the host bus adapter from which settings can be inherited.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

