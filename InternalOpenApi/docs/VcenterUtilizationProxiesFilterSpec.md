# Vcenter.Automation.OpenApi.Model.VcenterUtilizationProxiesFilterSpec
The Vcenter.Utilization.Proxies.FilterSpec schema defines a filter for listing proxy information. The result will contain elements which meet all criteria at the same time.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Services** | **List&lt;string&gt;** | List of services to be included in the final result.  This property was added in __vSphere API 9.1.0.0__.  if missing or &#x60;null&#x60; or empty, the result will not be filtered by service.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.services.Service&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.services.Service&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

