# Vcenter.Automation.OpenApi.Model.VcenterContentRegistriesHarborSummary
This schema is deprecated as of __vSphere API 8.0.1.00200__.  The Vcenter.Content.Registries.Harbor.Summary schema contains basic information about a running Harbor registry.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | **string** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Identifier of the cluster.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, container registry is not created on the cluster specified by *Vcenter.Content.Registries.Harbor.CreateSpec.cluster*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | [optional] 
**Registry** | **string** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Identifier of the registry.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.content.Registry&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.content.Registry&#x60;. | 
**VarVersion** | **string** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Version of the registry.  This property was added in __vSphere API 7.0.0.0__. | 
**UiAccessUrl** | **string** | This property is deprecated as of __vSphere API 8.0.1.00200__.  URL to access the UI of the registry.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

