# Vcenter.Automation.OpenApi.Model.VcenterCertificateManagementVcenterTrustedRootChainsCreateSpec
The Vcenter.CertificateManagement.Vcenter.TrustedRootChains.CreateSpec schema contains information to create a trusted root certificate chain.  This schema was added in __vSphere API 6.7.2__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CertChain** | [**VcenterCertificateManagementX509CertChain**](VcenterCertificateManagementX509CertChain.md) | Certificate chain in base64 encoding  This property was added in __vSphere API 6.7.2__. | 
**Chain** | **string** | Unique identifier for this trusted root. Client can specify at creation as long as it is unique, otherwise one will be generated. An example of a client providing the identifier would be if this trusted root is associated with a VC trust. In this case the identifier would be the domain id.  This property was added in __vSphere API 6.7.2__.  A unique id will be generated if not given. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

