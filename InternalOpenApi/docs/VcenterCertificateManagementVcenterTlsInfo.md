# Vcenter.Automation.OpenApi.Model.VcenterCertificateManagementVcenterTlsInfo
The Vcenter.CertificateManagement.Vcenter.Tls.Info schema contains information from a TLS certificate.  This schema was added in __vSphere API 6.7.2__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | **long** | Version (version number) value from the certificate.  This property was added in __vSphere API 6.7.2__. | 
**SerialNumber** | **string** | SerialNumber value from the certificate.  This property was added in __vSphere API 6.7.2__. | 
**SignatureAlgorithm** | **string** | Signature algorithm name from the certificate.  This property was added in __vSphere API 6.7.2__. | 
**IssuerDn** | **string** | Issuer (issuer distinguished name) value from the certificate.  This property was added in __vSphere API 6.7.2__. | 
**ValidFrom** | **DateTime** | validFrom specify the start date of the certificate.  This property was added in __vSphere API 6.7.2__. | 
**ValidTo** | **DateTime** | validTo specify the end date of the certificate.  This property was added in __vSphere API 6.7.2__. | 
**SubjectDn** | **string** | Subject (subject distinguished name) value from the certificate.  This property was added in __vSphere API 6.7.2__. | 
**Thumbprint** | **string** | Thumbprint value from the certificate.  This property was added in __vSphere API 6.7.2__. | 
**IsCa** | **bool** | Certificate constraints isCA from the critical BasicConstraints extension, (OID &#x3D; 2.5.29.19).  This property was added in __vSphere API 6.7.2__. | 
**PathLengthConstraint** | **long** | Certificate constraints path length from the critical BasicConstraints extension, (OID &#x3D; 2.5.29.19).  This property was added in __vSphere API 6.7.2__. | 
**KeyUsage** | **List&lt;string&gt;** | Collection of keyusage contained in the certificate.  This property was added in __vSphere API 6.7.2__. | 
**ExtendedKeyUsage** | **List&lt;string&gt;** | Collection of extended keyusage that contains details for which the certificate can be used for.  This property was added in __vSphere API 6.7.2__. | 
**SubjectAlternativeName** | **List&lt;string&gt;** | Collection of subject alternative names.  This property was added in __vSphere API 6.7.2__. | 
**AuthorityInformationAccessUri** | **List&lt;string&gt;** | Collection of authority information access URI.  This property was added in __vSphere API 6.7.2__. | 
**Cert** | **string** | TLS certificate in PEM format.  This property was added in __vSphere API 6.7.2__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

