# Vcenter.ViJson.OpenApi.Model.ProviderUnavailable
This exception is thrown if the VASA Provider on which the call is made is currently not available, e.g.  VASA Provider is in offline state. This error usually means the provider is temporarily unavailable due to network outage, etc. The client is expected to wait for some time and retry the same call.  This structure may be used only with operations rendered under `/sms`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FaultCause** | [**MethodFault**](MethodFault.md) | Fault which is the cause of this fault.  | [optional] 
**FaultMessage** | [**List&lt;LocalizableMessage&gt;**](LocalizableMessage.md) | Message which has details about the error Message can also contain a key to message catalog which can be used to generate better localized messages.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

