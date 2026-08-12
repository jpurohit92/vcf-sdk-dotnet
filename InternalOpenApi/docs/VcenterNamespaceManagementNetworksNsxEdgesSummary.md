# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksNsxEdgesSummary
The Vcenter.NamespaceManagement.Networks.Nsx.Edges.Summary schema contains the basic information about an Edge.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EdgeCluster** | **string** | Identifier of the Edge.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;NSXEdgeCluster&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;NSXEdgeCluster&#x60;. | 
**Name** | **string** | Human-readable identifier of the Edge.  This property was added in __vSphere API 8.0.0.1__. | 
**Path** | **string** | NSX Policy path of the Edge.  This property was added in __vSphere API 8.0.0.1__. | 
**Compatible** | **bool** | Compatibility of this Edge with vSphere Namespaces.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**IncompatibilityReasons** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | List of reasons for incompatibility. If empty, this Edge is compatible.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

