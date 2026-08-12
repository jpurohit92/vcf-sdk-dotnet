# Vcenter.Automation.OpenApi.Model.VcenterHostCryptoFipsModulesFilterSpec
The Vcenter.Host.Crypto.Fips.Modules.FilterSpec schema defines a filter for narrowing the returned crypto modules. The result will contain elements which meet all criteria. If none of the modules on some host meet the criteria this host will not be included in the result.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hosts** | **List&lt;string&gt;** | MoId of the hosts whose modules shall be included in the result; Up to 100 hosts can be specified.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; or empty, all hosts shall be included in the result.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;HostSystem&#x60;. | [optional] 
**Names** | **List&lt;string&gt;** | Name of modules which shall be included in the result. Up to 10 names can be specified.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; or empty, modules won&#39;t be filtered by name. | [optional] 
**Versions** | **List&lt;string&gt;** | Version of modules which shall be included in the result. Up to 10 versions can be specified.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60; or empty, modules won&#39;t be filtered by version. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

