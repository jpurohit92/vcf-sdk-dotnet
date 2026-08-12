# Vcenter.Automation.OpenApi.Model.VapiStdNestedLocalizableMessage
The Vapi.Std.NestedLocalizableMessage schema represents a nested within a parameter localizable string or message template. This schema is useful for modeling composite messages. Such messages are necessary to do correct pluralization of phrases, represent lists of several items etc.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the localizable string or message template.    This identifier is typically used to retrieve a locale-specific string or message template from a message catalog.  This property was added in __vSphere API 7.0.0.0__. | 
**Params** | [**Dictionary&lt;string, VapiStdLocalizationParam&gt;**](VapiStdLocalizationParam.md) | Named Arguments to be substituted into the message template.  This property was added in __vSphere API 7.0.0.0__.  services will not populate this field when there are no parameters to be substituted | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

