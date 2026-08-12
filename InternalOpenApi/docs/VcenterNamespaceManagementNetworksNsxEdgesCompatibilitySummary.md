# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksNsxEdgesCompatibilitySummary
This schema is deprecated as of __vSphere API 9.1.0.0__.  The Vcenter.NamespaceManagement.Networks.Nsx.Edges.Compatibility.Summary schema contains information about an Edge, including whether it is compatible with the vCenter Namespaces feature and incompatibility reasons.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EdgeCluster** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  Identifier of the Edge.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;NSXEdgeCluster&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;NSXEdgeCluster&#x60;. | 
**Name** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  User-friendly identifier of the Edge.  This property was added in __vSphere API 8.0.0.1__. | 
**Compatible** | **bool** | This property is deprecated as of __vSphere API 9.1.0.0__.  Compatibility of this Edge with vSphere Namespaces.  This property was added in __vSphere API 8.0.0.1__. | 
**IncompatibilityReasons** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | This property is deprecated as of __vSphere API 9.1.0.0__.  List of reasons for incompatibility. If empty, this Edge is compatible.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

