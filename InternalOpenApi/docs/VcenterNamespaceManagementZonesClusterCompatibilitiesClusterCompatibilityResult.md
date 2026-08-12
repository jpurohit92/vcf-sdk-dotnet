# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementZonesClusterCompatibilitiesClusterCompatibilityResult
The Vcenter.NamespaceManagement.Zones.ClusterCompatibilities.ClusterCompatibilityResult schema contains the result of the compatibility check.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | **string** | The identifier for the vSphere Cluster Compute Resource.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | 
**Compatible** | **bool** | Indicates if the vSphere Cluster Compute Resource is compatible with the vSphere Zone.  This property was added in __vSphere API 9.1.0.0__. | 
**CompatibilityMessages** | [**List&lt;VcenterNamespaceManagementZonesClusterCompatibilitiesCompatibilityMessage&gt;**](VcenterNamespaceManagementZonesClusterCompatibilitiesCompatibilityMessage.md) | The details about the compatibility of the Cluster Compute Resource.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

