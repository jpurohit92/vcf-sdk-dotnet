# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementClusterCompatibilitySummary
The Vcenter.NamespaceManagement.ClusterCompatibility.Summary schema contains the information about the compatibility of a vSphere cluster.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | **string** | Identifier of the vSphere cluster.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | 
**Compatible** | **bool** | Compatibility of this vSphere cluster. If false, the list of incompatibility issues will be given in the incompatibility_reasons field.  This property was added in __vSphere API 7.0.0.0__. | 
**IncompatibilityReasons** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | Reasons for incompatibility.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

