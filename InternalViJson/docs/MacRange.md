# Vcenter.ViJson.OpenApi.Model.MacRange

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | MAC address.  | 
**Mask** | **string** | Mask that is used in matching the MAC address.  A MAC address is considered matched if the \&quot;and\&quot; operation of the mask on the MAC address and *MacRange.address* yields the same result. For example, a MAC of \&quot;00:A0:FF:14:FF:29\&quot; is considered matched for a *MacRange.address* of \&quot;00:A0:C9:14:C8:29\&quot; and a *MacRange.mask* of \&quot;FF:FF:00:FF:00:FF\&quot;.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

