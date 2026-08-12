# Vcenter.Automation.OpenApi.Model.ApplianceUpdatePendingQuestion
The Appliance.Update.Pending.Question schema describes a item of information that must be provided by the user in order to install the update.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataItem** | **string** | ID of the data item  This property was added in __vSphere API 6.7__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.applicance.update.pending.dataitem&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.applicance.update.pending.dataitem&#x60;. | 
**Text** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Label for the item to be used in GUI/CLI  This property was added in __vSphere API 6.7__. | 
**Description** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Description of the item  This property was added in __vSphere API 6.7__. | 
**Type** | **string** | How this field shoudl be represented in GUI or CLI  Possible values:   - &#x60;PLAIN_TEXT&#x60;: plain text answer   - &#x60;BOOLEAN&#x60;: Yes/No,On/Off,Checkbox answer   - &#x60;PASSWORD&#x60;: Password (masked) answer   For more information see: *Appliance.Update.Pending.Question.InputType*.  This property was added in __vSphere API 6.7__. | 
**AllowedValues** | **List&lt;string&gt;** | List of allowed values  This property was added in __vSphere API 6.7__.  allowedValues If missing or &#x60;null&#x60; any value is valid. | [optional] 
**Regexp** | **string** | Regexp to validate the input  This property was added in __vSphere API 6.7__.  regexp If missing or &#x60;null&#x60; no validation will be performed. | [optional] 
**DefaultAnswer** | **string** | Default answer  This property was added in __vSphere API 6.7__.  defaultAnswer If missing or &#x60;null&#x60; then there is no default answer, so an explicit answer must be provided | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

