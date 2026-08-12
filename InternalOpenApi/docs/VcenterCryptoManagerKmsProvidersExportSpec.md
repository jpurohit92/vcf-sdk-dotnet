# Vcenter.Automation.OpenApi.Model.VcenterCryptoManagerKmsProvidersExportSpec
The Vcenter.CryptoManager.Kms.Providers.ExportSpec schema contains properties that are needed to export a provider.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Provider** | **string** | Provider identifier  This property was added in __vSphere API 7.0.2.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.crypto_manager.kms.provider&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.crypto_manager.kms.provider&#x60;. | 
**Password** | **string** | Password used to encrypt the exported configuration.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60; or empty, the configuration will not be encrypted. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

