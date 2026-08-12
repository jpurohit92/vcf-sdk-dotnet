# Vcenter.Automation.OpenApi.Model.ApplianceSystemCryptoHashInfo
Appliance.System.CryptoHash.Info schema Structure representing the current crypto hash state  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HashMode** | **string** | Hash type representing state of global hash switch Possible values: STRONG, COMPATIBLE  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.appliance.system.crypto_hash&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.appliance.system.crypto_hash&#x60;. | 
**AlgorithmStatus** | **string** | Status indicating whether all algorithms are strong  Possible values:   - &#x60;STRONG&#x60;   - &#x60;NOT_STRONG&#x60;   For more information see: *Appliance.System.CryptoHash.AlgorithmStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**HashAlgorithms** | **List&lt;string&gt;** | List of algorithms supported by hashMode  This property was added in __vSphere API 9.0.0.0__. | 
**Status** | **string** | Status of current hash mode  Possible values:   - &#x60;UP_TO_DATE&#x60;   - &#x60;RESTART_PENDING&#x60;   For more information see: *Appliance.System.CryptoHash.HashModeStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**CommonHash** | **string** | This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

