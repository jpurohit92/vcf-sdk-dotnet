# Vcenter.Automation.OpenApi.Model.VcenterCryptoManagerHostsKmsProvidersFilterSpec
The Vcenter.CryptoManager.Hosts.Kms.Providers.FilterSpec schema contains properties used to filter the results when listing providers.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Providers** | **List&lt;string&gt;** | Provider identifiers.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60; or empty, the result will not be filtered by provider identifier.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.crypto_manager.kms.provider&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.crypto_manager.kms.provider&#x60;. | [optional] 
**Health** | **List&lt;string&gt;** | Provider health status.  Possible values:   - &#x60;NONE&#x60;: No health status is available.   - &#x60;OK&#x60;: Operating normally.   - &#x60;WARNING&#x60;: Operating normally, but there is an issue that requires attention.   - &#x60;ERROR&#x60;: There is a critical issue that requires attention.   For more information see: *Vcenter.CryptoManager.Hosts.Kms.Providers.Health*.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60; or empty, the result will not be filtered by provider health status. | [optional] 
**Types** | **List&lt;string&gt;** | Provider types.  Possible values:   - &#x60;NATIVE&#x60;: Native provider   - &#x60;TRUST_AUTHORITY&#x60;: Trust Authority provider   For more information see: *Vcenter.CryptoManager.Hosts.Kms.Providers.Type*.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60; or empty, the result will not be filtered by provider type. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

