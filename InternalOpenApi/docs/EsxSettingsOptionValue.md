# Vcenter.Automation.OpenApi.Model.EsxSettingsOptionValue
Describes the key/value pair of an option.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The name of the option using dot notation to reflect the option&#39;s position in a hierarchy. For example, you might have an option called \&quot;Ethernet\&quot; and another option that is a child of that called \&quot;Connection\&quot;. In this case, the key for the latter could be defined as \&quot;Ethernet.Connection\&quot;  This property was added in __vSphere API 9.0.0.0__. | 
**Value** | **string** | The value of the option.  This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; if value is undefined. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

