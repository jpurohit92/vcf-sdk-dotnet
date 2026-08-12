# Vcenter.Automation.OpenApi.Model.VcenterTrustedInfrastructureHostsHardwareTpmEndorsementKeysFilterSpec
The Vcenter.TrustedInfrastructure.Hosts.Hardware.Tpm.EndorsementKeys.FilterSpec schema contains properties used to filter the results when listing the endorsement key.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Types** | **List&lt;string&gt;** | Type of the endorsement key.  Possible values:   - &#x60;RSA_2048&#x60;: The RSA 2048 bit key.   - &#x60;ECC_NIST_P_256&#x60;: The ECC NISTP-256 bit key.   For more information see: *Vcenter.TrustedInfrastructure.Hosts.Hardware.Tpm.EndorsementKeys.Type*.  This property was added in __vSphere API 8.0.0.1__.  if missing or &#x60;null&#x60; or empty, the result will not be filtered by types. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

