# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSupervisorServicesSignaturesImageStatus
The Vcenter.NamespaceManagement.Supervisors.SupervisorServices.Signatures.Image.Status enumerated type indicates the signature validation status.  Possible values:   - `TRUSTED`: Signature is trusted:       1. The image has not been altered since signing.      2. The image was published by Broadcom or a trusted third-party.     - `UNAVAILABLE`: Signature is unavailable, for example when the system cannot access the image registry.   - `UNSIGNED`: No signature is present for the image.   - `UNTRUSTED`: The signature is present but is not trusted.   This enumeration was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

