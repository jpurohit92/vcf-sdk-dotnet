# Vcenter.ViJson.OpenApi.Model.VsanDataDrivenAPIAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActionId** | **string** | The unique action ID  | 
**ActionLabel** | [**LocalizableMessage**](LocalizableMessage.md) | The localized label for the action that is displayed in the UI.  | 
**ActionDescription** | [**LocalizableMessage**](LocalizableMessage.md) | The localized description for the action that is displayed in the UI.  | 
**Enabled** | **bool** | True indicates the action will be enabled from UI.  In the data-driven action use case, it is not possible for it to be False.  | 
**Parameters** | [**List&lt;KeyValue&gt;**](KeyValue.md) | The action parameters which can be used as the parameters for this action API when calling from UI.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

