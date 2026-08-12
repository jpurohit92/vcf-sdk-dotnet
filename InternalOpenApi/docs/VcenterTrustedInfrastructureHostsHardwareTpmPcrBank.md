# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureHostsHardwareTpmPcrBank
The Vcenter.TrustedInfrastructure.Hosts.Hardware.Tpm.PcrBank schema contains information that describes digest information of a PCR bank.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Algorithm** | **string** | The hash algorithm that is used by TPM to calculate the PCR values.  Possible values:   - &#x60;SHA256&#x60;: The SHA 256 hash algorithm.   - &#x60;SHA384&#x60;: The SHA 384 hash algorithm.   - &#x60;SHA512&#x60;: The SHA 512 hash algorithm.   - &#x60;SM3_256&#x60;: The SM3 hash algorithm.   For more information see: *Vcenter.TrustedInfrastructure.Hosts.Hardware.Tpm.HashAlgorithm*.  This property was added in __vSphere API 8.0.0.1__. | 
**Pcrs** | **Dictionary&lt;string, byte[]&gt;** | The index of PCR and corresponding TPM digest value.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

