# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementEdgeClusterCompatibilitySummary
This schema is deprecated as of __vSphere API 9.1.0.0__.  The Vcenter.NamespaceManagement.EdgeClusterCompatibility.Summary schema contains information about an NSX Edge Cluster, including its compatibility with the vCenter Namespaces feature.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EdgeCluster** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  Identifier of the Edge Cluster.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;NSXEdgeCluster&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;NSXEdgeCluster&#x60;. | 
**DisplayName** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  Display name of the Edge Cluster.  This property was added in __vSphere API 7.0.0.0__. | 
**Compatible** | **bool** | This property is deprecated as of __vSphere API 9.1.0.0__.  Compatibility of this Edge Cluster with Namespaces feature.  This property was added in __vSphere API 7.0.0.0__. | 
**IncompatibilityReasons** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | This property is deprecated as of __vSphere API 9.1.0.0__.  List of reasons for incompatibility.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, this Edge Cluster is compatible. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

