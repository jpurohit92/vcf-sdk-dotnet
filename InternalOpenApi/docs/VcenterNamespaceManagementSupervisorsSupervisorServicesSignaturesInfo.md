# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSupervisorServicesSignaturesInfo
The Vcenter.NamespaceManagement.Supervisors.SupervisorServices.Signatures.Info schema provides signature verification details for a Supervisor Service version.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SupervisorName** | **string** | The name of the Supervisor managing the Service version.  This property was added in __vSphere API 9.1.0.0__. | 
**Status** | **string** | The overall trust status of the service version. This aggregates the status of all image package bundles referenced by the service version.  Possible values:   - &#x60;TRUSTED&#x60;: Service manifest is valid and the signature is trusted:       1. The service manifest is valid.      2. The image has not been altered since signing.      3. The image was published by Broadcom or a trusted third-party.     - &#x60;UNAVAILABLE&#x60;: Trust status is unavailable, for example if the system cannot access the image registry.   - &#x60;UNSIGNED&#x60;: Service is unsigned; no signature is present.   - &#x60;UNTRUSTED&#x60;: Service is signed by an untrusted authority.   - &#x60;UNSUPPORTED&#x60;: Signature verification is not supported; trust status cannot be determined.   For more information see: *Vcenter.NamespaceManagement.Supervisors.SupervisorServices.Signatures.Status*.  This property was added in __vSphere API 9.1.0.0__. | 
**Images** | [**List&lt;VcenterNamespaceManagementSupervisorsSupervisorServicesSignaturesImage&gt;**](VcenterNamespaceManagementSupervisorsSupervisorServicesSignaturesImage.md) | A list of container image artifacts and their corresponding signature verification results associated with the service version.  This property was added in __vSphere API 9.1.0.0__. | 
**LastVerifiedAt** | **DateTime** | Timestamp of the most recent verification attempt.  This property was added in __vSphere API 9.1.0.0__. | 
**Messages** | [**List&lt;VcenterNamespaceManagementSupervisorsSupervisorServicesSignaturesMessage&gt;**](VcenterNamespaceManagementSupervisorsSupervisorServicesSignaturesMessage.md) | A set of messages that provide additional details regarding the signature verification result. Returns an empty list if no messages are available or the Supervisor Service version is signed and trusted.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

