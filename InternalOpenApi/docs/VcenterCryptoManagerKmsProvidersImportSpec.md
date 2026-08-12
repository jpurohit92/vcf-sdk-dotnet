# Vcenter.Automation.OpenApi.Model.VcenterCryptoManagerKmsProvidersImportSpec
The Vcenter.CryptoManager.Kms.Providers.ImportSpec schema contains properties that are needed to import a provider.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Config** | **byte[]** | Configuration to import.  This property was added in __vSphere API 7.0.2.0__.  Currently this is required. Other import methods may be supported in the future. | [optional] 
**Password** | **string** | Password to decrypt the configuration to import.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60; or empty, configuration to import must be unencrypted. | [optional] 
**Constraints** | [**VcenterCryptoManagerKmsProvidersConstraintsSpec**](VcenterCryptoManagerKmsProvidersConstraintsSpec.md) | Constraints to impose on the imported provider  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60;, the imported provider constraints will match the exported provider constraints. | [optional] 
**DryRun** | **bool** | Whether to perform a trial import without actually creating a provider.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60;, a new provider will be created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

