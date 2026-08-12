# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureHostsHardwareTpmEndorsementKeysPolicyPcrSpec
The Vcenter.TrustedInfrastructure.Hosts.Hardware.Tpm.EndorsementKeys.PolicyPcrSpec schema contains information that can be used to construct a PCR policy session for unsealing a secret using the *POST /vcenter/trusted-infrastructure/hosts/{host}/hardware/tpm/{tpm}/endorsement-keys/{key}?action=unseal* operation.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Pcrs** | **byte[]** | The PCRs to which the data is sealed.    The PCR selection is a TPML_PCR_SELECTION structure.    Trusted Platform Module Library Part 2: Structures, Family \&quot;2.0\&quot;, Level 00 Revision 01.59, November 8, 2019, Section 10.9.7 TPML_PCR_SELECTION  This property was added in __vSphere API 8.0.0.1__. | 
**PcrDigest** | **byte[]** | The digest of the PCRs selected in *Vcenter.TrustedInfrastructure.Hosts.Hardware.Tpm.EndorsementKeys.PolicyPcrSpec.pcrs*.    The digest is a TPM2B_DIGEST structure.    Trusted Platform Module Library Part 2: Structures, Family \&quot;2.0\&quot;, Level 00 Revision 01.59, November 8, 2019, Section 10.4.2 TPM2B_DIGEST  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60;, then the PCR digest is calculated by the service based on the current PCR state. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

