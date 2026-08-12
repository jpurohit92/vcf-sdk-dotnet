# Vcenter.ViJson.OpenApi.Model.ProviderUnregistrationFault
This fault is thrown if failed to unregister provider from storage management service.  This structure may be used only with operations rendered under `/sms`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FaultCause** | [**MethodFault**](MethodFault.md) | Fault which is the cause of this fault.  | [optional] 
**FaultMessage** | [**List&lt;LocalizableMessage&gt;**](LocalizableMessage.md) | Message which has details about the error Message can also contain a key to message catalog which can be used to generate better localized messages.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

