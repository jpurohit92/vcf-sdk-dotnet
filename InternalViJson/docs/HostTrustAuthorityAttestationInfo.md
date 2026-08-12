# Vcenter.ViJson.OpenApi.Model.HostTrustAuthorityAttestationInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttestationStatus** | **string** | Status of the attestation.  See *HostTrustAuthorityAttestationInfoAttestationStatus_enum* for the supported values.  | 
**ServiceId** | **string** | ID of the attestation service in case of attestation success.  Unset when not attested.  | [optional] 
**AttestedAt** | **DateTime** | Time of attestation.  | [optional] 
**AttestedUntil** | **DateTime** | Time until attestation is valid.  | [optional] 
**Messages** | [**List&lt;LocalizableMessage&gt;**](LocalizableMessage.md) | Messages explaining attestation failure or attestation status retrieval errors, if any.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

