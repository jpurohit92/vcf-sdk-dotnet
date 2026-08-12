# Vcenter.Automation.OpenApi.Model.VcenterEvcModesSource
Vcenter.EvcModes.Source are the objects used as input in the creation of custom Vcenter.EvcMode.EvcMode objects.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServiceLocator** | [**VcenterServiceLocator**](VcenterServiceLocator.md) | The vCenter Server location from which the objects are referenced.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the current vCenter server will be used. | [optional] 
**Clusters** | **List&lt;string&gt;** | The clusters to be used as reference objects.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, then no clusters are used for computing the custom EVC mode. At least ne of &#x60;clusters&#x60; or &#x60;hosts&#x60; must be specified.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. | [optional] 
**Hosts** | **List&lt;string&gt;** | The hosts to be used as reference objects.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, then no hosts are used for computing the the custom EVC mode. At least one of &#x60;clusters&#x60; or &#x60;hosts&#x60; must be specified.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;HostSystem&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

