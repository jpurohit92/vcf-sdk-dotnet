# Vcenter.Automation.OpenApi.Model.ApplianceSystemCryptoHashOptionsInfo
Appliance.System.CryptoHash.Options.Info schema Structure representing hash mode and supported hash algorithms  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HashMode** | **string** | Hash mode representing state of global hash switch  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.appliance.system.crypto_hash&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.appliance.system.crypto_hash&#x60;. | 
**HashAlgorithms** | **List&lt;string&gt;** | List of hash algorithms supported for a hash mode  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

