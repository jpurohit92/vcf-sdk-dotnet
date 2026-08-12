# Vcenter.Automation.OpenApi.Model.EsxHostsSolutionInfo
The Esx.Hosts.SolutionInfo schema contains properties that describe solution registered in the software solution.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | **string** | Version of the solution.  This property was added in __vSphere API 7.0.0.0__. | 
**DisplayName** | **string** | Display name of the solution.  This property was added in __vSphere API 7.0.0.0__. | 
**Components** | [**Dictionary&lt;string, EsxHostsComponentInfo&gt;**](EsxHostsComponentInfo.md) | Components registered by the solution.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.hosts.component&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.hosts.component&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

