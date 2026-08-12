# Vcenter.ViJson.OpenApi.Model.ProviderOutOfProvisioningResource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FaultCause** | [**MethodFault**](MethodFault.md) | Fault which is the cause of this fault.  | [optional] 
**FaultMessage** | [**List&lt;LocalizableMessage&gt;**](LocalizableMessage.md) | Message which has details about the error Message can also contain a key to message catalog which can be used to generate better localized messages.  | [optional] 
**ProvisioningResourceId** | **string** | Identifier of the provisioning resource.  | 
**AvailableBefore** | **long** | Currently available.  | [optional] 
**AvailableAfter** | **long** | Necessary for provisioning.  | [optional] 
**Total** | **long** | Total amount (free + used).  | [optional] 
**IsTransient** | **bool** | This resource limitation is transient, i.e.  the resource will be available after some time.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

