# Vcenter.ViJson.OpenApi.Model.CryptoManagerKmipClusterStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterId** | [**KeyProviderId**](KeyProviderId.md) | The ID of the KMIP cluster.  | 
**OverallStatus** | **ManagedEntityStatusEnum** | KMS cluster overall status.  | [optional] 
**ManagementType** | **string** | Key provider management type.  See *KmipClusterInfoKmsManagementType_enum* for valid values.  | [optional] 
**Servers** | [**List&lt;CryptoManagerKmipServerStatus&gt;**](CryptoManagerKmipServerStatus.md) | Status of the KMIP servers in this cluster.  | 
**ClientCertInfo** | [**CryptoManagerKmipCertificateInfo**](CryptoManagerKmipCertificateInfo.md) | The basic information about the client&#39;s certificate.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

