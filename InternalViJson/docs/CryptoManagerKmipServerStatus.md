# Vcenter.ViJson.OpenApi.Model.CryptoManagerKmipServerStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the KMIP server.  | 
**Status** | **ManagedEntityStatusEnum** | KMIP server status.  | 
**ConnectionStatus** | **string** | KMIP server connection status description.  | 
**CertInfo** | [**CryptoManagerKmipCertificateInfo**](CryptoManagerKmipCertificateInfo.md) | The basic information about the KMIP server&#39;s certificate.  | [optional] 
**ClientTrustServer** | **bool** | Whether this KMS server is trusted by local Kmip client.  | [optional] 
**ServerTrustClient** | **bool** | Whether this KMS server trusts the local Kmip client.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

