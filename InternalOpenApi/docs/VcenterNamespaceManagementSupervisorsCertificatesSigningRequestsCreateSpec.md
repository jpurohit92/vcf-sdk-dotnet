# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsCertificatesSigningRequestsCreateSpec
The Vcenter.NamespaceManagement.Supervisors.Certificates.SigningRequests.CreateSpec schema contains the specification required to create new Certificate Signing Request for the Supervisor.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CsrType** | **string** | Certificate Signing Request kind.  Possible values:   - &#x60;DEFAULT_NSX_INGRESS&#x60;: Certificate Signing Request to be signed and used by NSX as a default fallback certificate for Kubernetes Ingress objects.   - &#x60;KUBERNETES_API_SERVER&#x60;: Certificate Signing Request to be signed and used by the Supervisor Kubernetes API Server.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Certificates.SigningRequests.CSRType*.  This property was added in __vSphere API 9.1.0.0__. | 
**KeySize** | **long** | Size of key associated with the new Certificate Signing Request.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the generated key will be 3072 bits long. | [optional] 
**CommonName** | **string** | Name identifying the machine. Its value will be set in Certificate Signing Request Subject&#39;s CN field.  This property was added in __vSphere API 9.1.0.0__. | 
**Country** | **string** | Two-letter country code (as defined in ISO-3166) to be set in Certificate Signing Request Subject&#39;s C field.  This property was added in __vSphere API 9.1.0.0__. | 
**StateOrProvince** | **string** | State or province to be set in Certificate Signing Request Subject&#39;s ST field.  This property was added in __vSphere API 9.1.0.0__. | 
**Locality** | **string** | Locality (city) to be set in Certificate Signing Request Subject&#39;s L field.  This property was added in __vSphere API 9.1.0.0__. | 
**OrganizationName** | **string** | Organization to be set in Certificate Signing Request Subject&#39;s O field.  This property was added in __vSphere API 9.1.0.0__. | 
**OrganizationUnitName** | **string** | Organizational Unit to be set in Certificate Signing Request Subject&#39;s OU field.  This property was added in __vSphere API 9.1.0.0__. | 
**EmailAddress** | **string** | Email to be set in Certificate Signing Request Subject Alternative Names.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no email address will be set in the Certificate Signing Request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

