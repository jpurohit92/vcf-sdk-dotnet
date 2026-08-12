# Vcenter.Automation.OpenApi.Model.VcenterHostCryptoFipsModulesIterationSpec
The Vcenter.Host.Crypto.Fips.Modules.IterationSpec schema contains properties used to break results into pages when listing files. Results are sorted by the MoNums of the hosts.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Marker** | **string** | MoId of the last host whose modules were already returned. Iteration shall continue form the next one.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; the first set of items is returned. | [optional] 
**PageSize** | **long** | Specifies the maximum number of hosts whose modules shall be returned.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; the full list of modules shall be returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

