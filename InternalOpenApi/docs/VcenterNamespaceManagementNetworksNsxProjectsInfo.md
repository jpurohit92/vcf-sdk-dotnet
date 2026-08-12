# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksNsxProjectsInfo
The Vcenter.NamespaceManagement.Networks.Nsx.Projects.Info schema contains information about an NSX Project.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Project** | **string** | Identifier of the Project.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;NSXProject&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;NSXProject&#x60;. | 
**Name** | **string** | Name of the Project.  This property was added in __vSphere API 9.0.0.0__. | 
**Description** | **string** | Description of the Project.  This property was added in __vSphere API 9.0.0.0__. | 
**NsxPath** | **string** | NSX path of the Project.  This property was added in __vSphere API 9.0.0.0__. | 
**Gateways** | [**List&lt;VcenterNamespaceManagementNetworksNsxProjectsNsxGatewayInfo&gt;**](VcenterNamespaceManagementNetworksNsxProjectsNsxGatewayInfo.md) | List of NSX Tier0 or Tier0-VRF gateways currently configured with the project.  This property was added in __vSphere API 9.0.0.0__. | 
**EdgeClusters** | [**List&lt;VcenterNamespaceManagementNetworksNsxProjectsEdgeClusterInfo&gt;**](VcenterNamespaceManagementNetworksNsxProjectsEdgeClusterInfo.md) | List of NSX Edge Clusters currently configured with the project.  This property was added in __vSphere API 9.0.0.0__. | 
**ExternalIpv4Blocks** | [**List&lt;VcenterNamespaceManagementNetworksNsxIPBlockInfo&gt;**](VcenterNamespaceManagementNetworksNsxIPBlockInfo.md) | List of NSX External IPv4 Blocks currently configured with the project.  This property was added in __vSphere API 9.0.0.0__. | 
**DefaultProject** | **bool** | &#x60;true&#x60; if this Project is the default Project in NSX, &#x60;false&#x60; otherwise.  This property was added in __vSphere API 9.0.0.0__. | 
**VpcConnectivityProfiles** | [**List&lt;VcenterNamespaceManagementNetworksNsxProjectsVpcConnectivityProfileInfo&gt;**](VcenterNamespaceManagementNetworksNsxProjectsVpcConnectivityProfileInfo.md) | VPC Connectivity Profile under this project.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

