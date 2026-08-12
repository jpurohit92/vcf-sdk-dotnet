# Vcenter.ViJson.OpenApi.Model.TooMany

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FaultCause** | [**MethodFault**](MethodFault.md) | Fault which is the cause of this fault.  | [optional] 
**FaultMessage** | [**List&lt;LocalizableMessage&gt;**](LocalizableMessage.md) | Message which has details about the error Message can also contain a key to message catalog which can be used to generate better localized messages.  | [optional] 
**MaxBatchSize** | **long** | Maximum number of elements in batch that the VASA Provider can support for the specific API.  If the value is not specified (zero) or invalid (negative), client will assume the default value is 1.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

