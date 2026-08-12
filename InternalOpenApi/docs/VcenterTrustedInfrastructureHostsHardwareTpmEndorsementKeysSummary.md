# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureHostsHardwareTpmEndorsementKeysSummary
The Vcenter.TrustedInfrastructure.Hosts.Hardware.Tpm.EndorsementKeys.Summary schema contains information that describes a TPM endorsement key.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | A unique identifier for the TPM endorsement key.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.hosts.hardware.tpm.EndorsementKey&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.hosts.hardware.tpm.EndorsementKey&#x60;. | 
**Type** | **string** | The TPM endorsement key type.  Possible values:   - &#x60;RSA_2048&#x60;: The RSA 2048 bit key.   - &#x60;ECC_NIST_P_256&#x60;: The ECC NISTP-256 bit key.   For more information see: *Vcenter.TrustedInfrastructure.Hosts.Hardware.Tpm.EndorsementKeys.Type*.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

