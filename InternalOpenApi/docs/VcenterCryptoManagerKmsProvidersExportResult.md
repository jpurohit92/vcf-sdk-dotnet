# Vcenter.Automation.OpenApi.Model.VcenterCryptoManagerKmsProvidersExportResult
The Vcenter.CryptoManager.Kms.Providers.ExportResult schema contains result of *POST /vcenter/crypto-manager/kms/providers?action=export* operation.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of provider export result  Possible values:   - &#x60;LOCATION&#x60;: Result returned as a URL from which the provider configuration can be downloaded.   For more information see: *Vcenter.CryptoManager.Kms.Providers.ExportType*.  This property was added in __vSphere API 7.0.2.0__. | 
**Location** | [**VcenterCryptoManagerKmsProvidersLocation**](VcenterCryptoManagerKmsProvidersLocation.md) | Location of the exported configuration  This property was added in __vSphere API 7.0.2.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.CryptoManager.Kms.Providers.ExportType.LOCATION*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

