# Vcenter.Automation.OpenApi.Model.VapiStdLocalizableMessage
The Vapi.Std.LocalizableMessage schema represents localizable string and message template. Resources include one or more localizable message templates in the errors they report so that clients can display diagnostic messages in the native language of the user. Resources can include localizable strings in the data returned from operations to allow clients to display localized status information in the native language of the user.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the localizable string or message template.    This identifier is typically used to retrieve a locale-specific string or message template from a message catalog. | 
**DefaultMessage** | **string** | The value of this localizable string or message template in the &#x60;en_US&#x60; (English) locale. If *Vapi.Std.LocalizableMessage.id* refers to a message template, the default message will contain the substituted arguments. This value can be used by clients that do not need to display strings and messages in the native language of the user. It could also be used as a fallback if a client is unable to access the appropriate message catalog. | 
**Args** | **List&lt;string&gt;** | Positional arguments to be substituted into the message template. This list will be empty if the message uses named arguments or has no arguments. | 
**Params** | [**Dictionary&lt;string, VapiStdLocalizationParam&gt;**](VapiStdLocalizationParam.md) | Named arguments to be substituted into the message template.  This property was added in __vSphere API 7.0.0.0__.  Missing or &#x60;null&#x60; means that the message template requires no arguments or positional arguments are used. | [optional] 
**Localized** | **string** | Localized string value as per request requirements.  This property was added in __vSphere API 7.0.0.0__.  when the client has not requested specific locale the implementation may not populate this field to conserve resources. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

