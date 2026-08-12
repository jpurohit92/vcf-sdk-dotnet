# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementClusterCompatibilityZoneSummary
The Vcenter.NamespaceManagement.ClusterCompatibility.ZoneSummary schema contains the information about the compatibility of a vSphere Zone and the vSphere clusters associated with it.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Zone** | **string** | Identifier of this vSphere Zone.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. | 
**Compatible** | **bool** | Flag to indicate whether the current Zone can be used to enable a Supervisor cluster. If false, the list of incompatibility issues will be given in the cluster_summaries field.  This property was added in __vSphere API 8.0.0.1__. | 
**ClusterSummaries** | [**List&lt;VcenterNamespaceManagementClusterCompatibilitySummary&gt;**](VcenterNamespaceManagementClusterCompatibilitySummary.md) | A list of information about the compatibility of vSphere clusters associated with this vSphere Zone.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

