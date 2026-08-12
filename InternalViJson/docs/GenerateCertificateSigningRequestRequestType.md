# Vcenter.ViJson.OpenApi.Model.GenerateCertificateSigningRequestRequestType
The parameters of *HostCertificateManager.GenerateCertificateSigningRequest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UseIpAddressAsCommonName** | **bool** | if true, use host&#39;s management IP address as CN in the CSR; otherwise use host&#39;s FQDN.  | 
**Spec** | [**HostCertificateManagerCertificateSpec**](HostCertificateManagerCertificateSpec.md) | is used to generate CSR for selected certificate kind.  ***Since:*** vSphere API Release 8.0.1.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

