# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureHostsHardwareTpmEndorsementKeysInfo
The Vcenter.TrustedInfrastructure.Hosts.Hardware.Tpm.EndorsementKeys.Info schema contains information that describes a TPM endorsement key.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The TPM endorsement key type.  Possible values:   - &#x60;RSA_2048&#x60;: The RSA 2048 bit key.   - &#x60;ECC_NIST_P_256&#x60;: The ECC NISTP-256 bit key.   For more information see: *Vcenter.TrustedInfrastructure.Hosts.Hardware.Tpm.EndorsementKeys.Type*.  This property was added in __vSphere API 8.0.0.1__. | 
**PublicArea** | **byte[]** | The TPM endorsement key public area.    The public area is a TPM2B_PUBLIC structure.    Trusted Platform Module Library Part 2: Structures, Family \&quot;2.0\&quot;, Level 00 Revision 01.59, November 8, 2019, Section 12.2.5 TPM2B_PUBLIC  This property was added in __vSphere API 8.0.0.1__. | 
**Name** | **byte[]** | The TPM endorsement key name.    The name is a TPM2B_NAME structure.    Trusted Platform Module Library Part 2: Structures, Family \&quot;2.0\&quot;, Level 00 Revision 01.59, November 8, 2019, Section 10.5.3 TPM2B_NAME  This property was added in __vSphere API 8.0.0.1__. | 
**QualifiedName** | **byte[]** | The TPM endorsement key qualified name.    The qualified name is a TPM2B_NAME structure.    Trusted Platform Module Library Part 2: Structures, Family \&quot;2.0\&quot;, Level 00 Revision 01.59, November 8, 2019, Section 10.5.3 TPM2B_NAME  This property was added in __vSphere API 8.0.0.1__. | 
**PublicKey** | **string** | The TPM public endorsement key in PEM format.  This property was added in __vSphere API 8.0.0.1__.  if missing or &#x60;null&#x60;, the PEM format public key could not be determined. | [optional] 
**Certificate** | **string** | The TPM endorsement key certificate in PEM format.  This property was added in __vSphere API 8.0.0.1__.  if missing or &#x60;null&#x60;, the certificate cannot be retrieved from the TPM. | [optional] 
**ManufacturerCertificateUri** | **string** | The TPM endorsement key issuer URL extracted from the TPM endorsement key certificate.  This property was added in __vSphere API 8.0.0.1__.  if missing or &#x60;null&#x60;, the URI cannot be retrieved from the endorsement key certificate. | [optional] 
**ManufacturerCertificates** | [**VcenterTrustedInfrastructureX509CertChain**](VcenterTrustedInfrastructureX509CertChain.md) | The TPM manufacturer&#39;s endorsement key certificate chain.    Endorsement key certificates are signed by the TPM manufacturer. When available, the manufacturer_certificates property will contain the TPM manufacturer&#39;s endorsement key certificate chain.  This property was added in __vSphere API 8.0.0.1__.  if missing or &#x60;null&#x60;, the certificate chain is not available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

