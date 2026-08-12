# Vcenter.ViJson.OpenApi.Model.HostGatewaySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GatewayType** | **string** | The type of the gateway used for the communication to the host.  | 
**GatewayId** | **string** | Identifier of the gateway to be used for communction to the host.  If omitted a random gateway of this type will be selected.  | [optional] 
**TrustVerificationToken** | **string** | An opaque string that the gateway may need to validate that the host it connects to is the correct host.  | [optional] 
**HostAuthParams** | [**List&lt;KeyValue&gt;**](KeyValue.md) | Additional opaque authentication data that the gateway may need to authenticate to the host.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

