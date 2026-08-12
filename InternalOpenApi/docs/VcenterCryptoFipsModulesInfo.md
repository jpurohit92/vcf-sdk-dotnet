# Vcenter.Automation.OpenApi.Model.VcenterCryptoFipsModulesInfo
The Vcenter.Crypto.Fips.Modules.Info schema contains information about a FIPS validated crypto module.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the module as specified in its certificate.  This property was added in __vSphere API 9.1.0.0__. | 
**VarVersion** | **string** | Version of the module.  This property was added in __vSphere API 9.1.0.0__. | 
**CmvpCert** | **string** | CMVP certificate number of the module. Can be used to construct the URL of the certificate, for example: https://csrc.nist.gov/projects/cryptographic-module-validation-program/certificate/4743  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the module&#39;s CMVP certification is still pending. | [optional] 
**CavpCert** | **string** | CAVP certificate number of the module&#39;s algorithms. Can be used to construct the URL of the certificate, for example: https://csrc.nist.gov/projects/Cryptographic-Algorithm-Validation-Program/details?source&#x3D;A&amp;number&#x3D;3500  This property was added in __vSphere API 9.1.0.0__.  May be left missing or &#x60;null&#x60;, if the module has a CMVP certificate issued. | [optional] 
**ComponentName** | **string** | VCF component on which this module is installed.  This property was added in __vSphere API 9.1.0.0__.  Can be left missing or &#x60;null&#x60; for modules installed on the vCenter. | [optional] 
**ComponentVersion** | **string** | Version of the VCF component on which this module is installed.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

