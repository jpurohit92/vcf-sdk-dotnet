# Vcenter.Automation.OpenApi.Model.VcenterContentRegistriesHarborCreateSpec
This schema is deprecated as of __vSphere API 8.0.1.00200__.  The Vcenter.Content.Registries.Harbor.CreateSpec schema contains the specification required to create a Harbor registry.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | **string** | This property is deprecated as of __vSphere API 8.0.1.00200__.  Identifier of the cluster hosting the registry.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, registry will not be created on a specified cluster. This is required in current version, since Harbor can only be created on a cluster with Kubernetes enabled.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | [optional] 
**GarbageCollection** | [**VcenterContentRegistriesHarborGarbageCollection**](VcenterContentRegistriesHarborGarbageCollection.md) | This property is deprecated as of __vSphere API 8.0.1.00200__.  Garbage collection configuration for the Harbor registry.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, a default configuration is set, Recurrence#WEEKLY, DayOfWeek#SATURDAY, GarbageCollection#hour is 2, GarbageCollection#minute is 0. | [optional] 
**Storage** | [**List&lt;VcenterContentRegistriesHarborStorageSpec&gt;**](VcenterContentRegistriesHarborStorageSpec.md) | This property is deprecated as of __vSphere API 8.0.1.00200__.  Storage associated with the Harbor registry. The list contains only one storage backing in this version.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

