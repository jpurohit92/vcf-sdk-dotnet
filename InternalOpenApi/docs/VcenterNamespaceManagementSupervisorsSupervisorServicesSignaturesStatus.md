# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSupervisorServicesSignaturesStatus
The Vcenter.NamespaceManagement.Supervisors.SupervisorServices.Signatures.Status enumerated type indicates the trust status of a Supervisor Service version.  Possible values:   - `TRUSTED`: Service manifest is valid and the signature is trusted:       1. The service manifest is valid.      2. The image has not been altered since signing.      3. The image was published by Broadcom or a trusted third-party.     - `UNAVAILABLE`: Trust status is unavailable, for example if the system cannot access the image registry.   - `UNSIGNED`: Service is unsigned; no signature is present.   - `UNTRUSTED`: Service is signed by an untrusted authority.   - `UNSUPPORTED`: Signature verification is not supported; trust status cannot be determined.   This enumeration was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

