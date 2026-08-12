# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksNsxProjectsVpcconnectivityprofilesCompatibilityFilterSpec
The Vcenter.NamespaceManagement.Networks.Nsx.Projects.Vpcconnectivityprofiles.Compatibility.FilterSpec schema contains properties used to validate the Span of Transit Gateway when checking VPC Connectivity Profile compatibility (see *POST /vcenter/namespace-management/networks/nsx/projects/{project}/vpc-connectivity-profiles/{profile}?action=check-compatibility*). Either #zones or #cluster should be set, but not both.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | **string** | Identifier of the cluster backing a Supervisor.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the Transit Gateway in the VPC Connectivity Profile does not need to span the cluster.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

