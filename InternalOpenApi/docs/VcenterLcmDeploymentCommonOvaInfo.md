# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentCommonOvaInfo
The Vcenter.Lcm.Deployment.Common.OvaInfo schema defines the OVA file location info to be used by the lifecycle service.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Location** | **string** | The location of the OVA file for installation. It can be web URL or absolute filepath i.e https://server.com/appliance.ova or file://storage/appliance.ova  This property was added in __vSphere API 9.0.0.0__. | 
**SslVerify** | **bool** | A flag to indicate whether SSL verification is required for the ova location.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; defaults to True | [optional] 
**OvaChecksum** | **string** | Checksum to validate the OVA file.  This property was added in __vSphere API 9.0.0.0__.  If set will be used for checksum validation of the ova file on the vCenter. | [optional] 
**OvaChecksumAlgorithm** | **string** | The hash algorithm (HashAlgorithm) used to calculate the checksum.  Possible values:   - &#x60;SHA256&#x60;: Hash algorithm: SHA-256   - &#x60;SHA512&#x60;: Hash algorithm: SHA-512   For more information see: *Vcenter.Lcm.Deployment.Common.HashAlgorithm*.  This property was added in __vSphere API 9.0.0.0__.  If not specified the default checksum algorithm is *Vcenter.Lcm.Deployment.Common.HashAlgorithm.SH_a256*. | [optional] 
**Certificate** | **string** | Certificate to verify the SSL OVA location. The value should be the x509 leaf certificate encoded in PEM format.     - If ssl_verify is true and this field is omitted. a CA based validation will be used.    - If ssl_verify is true and this field is provided will be used for SSL validation.    This property was added in __vSphere API 9.0.0.0__.  If set will be used for SSL validation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

