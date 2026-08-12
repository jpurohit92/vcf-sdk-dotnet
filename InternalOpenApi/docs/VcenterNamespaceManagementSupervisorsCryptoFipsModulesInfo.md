# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsCryptoFipsModulesInfo
The Vcenter.NamespaceManagement.Supervisors.Crypto.Fips.Modules.Info schema contains information about a FIPS validated crypto module.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the module as specified in its certificate.  This property was added in __vSphere API 9.1.0.0__. | 
**VarVersion** | **string** | Version of the module.  This property was added in __vSphere API 9.1.0.0__. | 
**CmvpCert** | **string** | Cryptographic Module Validation Program (CMVP) certificate number of the module. Use it to construct the URL of the certificate, Please refer: https://csrc.nist.gov/projects/cryptographic-module-validation-program/certificate/4743  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the module&#39;s CMVP certification is still pending. | [optional] 
**CavpCert** | **string** | Cryptographic Algorithm Validation Program (CAVP) certificate number of the module&#39;s algorithms. Use it to construct the URL of the certificate, Please refer: https://csrc.nist.gov/projects/Cryptographic-Algorithm-Validation-Program/details?source&#x3D;A&amp;number&#x3D;3500  This property was added in __vSphere API 9.1.0.0__.  missing or &#x60;null&#x60;, if the module has a CMVP certificate issued. | [optional] 
**ComponentName** | **string** | VCF component on which this module is installed. It is Supervisor by default.  This property was added in __vSphere API 9.1.0.0__. | 
**ComponentVersion** | **string** | Version of the Supervisor on which this module is installed.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

