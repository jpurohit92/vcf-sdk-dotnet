# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureHostsHardwareTpmInfo
The Vcenter.TrustedInfrastructure.Hosts.Hardware.Tpm.Info schema contains information that describes a TPM device.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MajorVersion** | **long** | The TPM major version number.  This property was added in __vSphere API 8.0.0.1__. | 
**MinorVersion** | **long** | The TPM minor version number.  This property was added in __vSphere API 8.0.0.1__. | 
**Active** | **bool** | The TPM status.    Inactive TPMs cannot be used for sealing or attestation.  This property was added in __vSphere API 8.0.0.1__. | 
**Manufacturer** | **string** | The TPM manufacturer.  This property was added in __vSphere API 8.0.0.1__.  if missing or &#x60;null&#x60;, manufacturer is not available. | [optional] 
**Model** | **string** | The TPM model.  This property was added in __vSphere API 8.0.0.1__.  if missing or &#x60;null&#x60;, model is not available. | [optional] 
**FirmwareVersion** | **string** | The TPM firmware version.  This property was added in __vSphere API 8.0.0.1__.  if missing or &#x60;null&#x60;, firmware version is not available. | [optional] 
**Banks** | [**List&lt;VcenterTrustedInfrastructureHostsHardwareTpmPcrBank&gt;**](VcenterTrustedInfrastructureHostsHardwareTpmPcrBank.md) | The list of the PCR banks of the TPM device.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

