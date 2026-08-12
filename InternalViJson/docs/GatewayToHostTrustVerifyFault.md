# Vcenter.ViJson.OpenApi.Model.GatewayToHostTrustVerifyFault

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | Hostname of the host that the gateway is communicating with.  | 
**Port** | **int** | Port specified for the connection between the gateway and the host.  | [optional] 
**VerificationToken** | **string** | A unique verification token, that can be used to state the the listed properties are valid.  | 
**PropertiesToVerify** | [**List&lt;KeyValue&gt;**](KeyValue.md) | A key/value list of properties that need user verification in order for the gateway to trust the host to succeed.  For instance the user may need to verify an SSL thumbprint or a whole certificate.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

