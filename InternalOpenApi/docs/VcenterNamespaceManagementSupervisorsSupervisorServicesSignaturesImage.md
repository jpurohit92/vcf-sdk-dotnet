# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSupervisorServicesSignaturesImage
This Vcenter.NamespaceManagement.Supervisors.SupervisorServices.Signatures.Image schema contains metadata of an OCI image, including its signature details.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | A reference to an OCI image, including the registry host, repository (URL path) and image name.  This property was added in __vSphere API 9.1.0.0__. | 
**Digest** | **string** | SHA-256 hash of the image content, used to verify its integrity.  This property was added in __vSphere API 9.1.0.0__. | 
**Status** | **string** | The signature validation status of the image.  Possible values:   - &#x60;TRUSTED&#x60;: Signature is trusted:       1. The image has not been altered since signing.      2. The image was published by Broadcom or a trusted third-party.     - &#x60;UNAVAILABLE&#x60;: Signature is unavailable, for example when the system cannot access the image registry.   - &#x60;UNSIGNED&#x60;: No signature is present for the image.   - &#x60;UNTRUSTED&#x60;: The signature is present but is not trusted.   For more information see: *Vcenter.NamespaceManagement.Supervisors.SupervisorServices.Signatures.Image.Status*.  This property was added in __vSphere API 9.1.0.0__. | 
**CertificateChain** | **List&lt;string&gt;** | The certificate chain used to verify the signature of the OCI image. The chain is returned in PEM format, starting with the leaf certificate.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the image is either unsigned or the signature could not be retrieved. | [optional] 
**LastVerifiedAt** | **DateTime** | Timestamp of the most recent signature verification attempt for the image.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

