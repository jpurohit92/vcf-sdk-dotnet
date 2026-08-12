# Vcenter.Automation.OpenApi.Model.VcenterHostCryptoFipsModulesListResult
The Vcenter.Host.Crypto.Fips.Modules.ListResult schema contains a list of FIPS validated crypto module installed on a host in the VC's fleet.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Items** | [**List&lt;VcenterHostCryptoFipsModulesListItem&gt;**](VcenterHostCryptoFipsModulesListItem.md) | The list of modules.  This property was added in __vSphere API 9.1.0.0__. | 
**Marker** | **string** | Host moId indicating the host from which the next page of results shall continue. Clients should use this value in the subsequent calls to the #list(IterationSpec) API.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; the full list of modules is returned or no modules matched the provided filter. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

