# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureHostsHardwareTpmSummary
The Vcenter.TrustedInfrastructure.Hosts.Hardware.Tpm.Summary schema contains information that summarizes a TPM.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tpm** | **string** | A unique identifier for the TPM instance.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.hosts.hardware.Tpm&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.trusted_infrastructure.hosts.hardware.Tpm&#x60;. | 
**MajorVersion** | **long** | The TPM major version number.  This property was added in __vSphere API 8.0.0.1__. | 
**MinorVersion** | **long** | The TPM minor version number.  This property was added in __vSphere API 8.0.0.1__. | 
**Active** | **bool** | The TPM status.    Inactive TPMs cannot be used for sealing or attestation.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

