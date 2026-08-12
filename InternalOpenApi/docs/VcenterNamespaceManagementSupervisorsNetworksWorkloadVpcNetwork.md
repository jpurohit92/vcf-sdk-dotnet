# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsNetworksWorkloadVpcNetwork
Vcenter.NamespaceManagement.Supervisors.Networks.Workload.VpcNetwork specifies network backing configuration that is specific to the workload network. It is used for configuring the Supervisor default settings.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NsxProject** | **string** | *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.VpcNetwork.nsx_project* is the default Project for VPCs in the Supervisor, including the System VPC, and Supervisor Services VPC. It needs to be NSX path of Project.   *GET /vcenter/namespace-management/networks/nsx/projects* can be used to list projects.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, use the default Project on NSX. | [optional] 
**VpcConnectivityProfile** | **string** | *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.VpcNetwork.vpc_connectivity_profile* describes the configuration for how a VPC is constructed, including it&#39;s Transit Gateway Attachments, IP blocks, and other settings on NSX. It needs to be NSX path of VPC Connectivity Profile.   *GET /vcenter/namespace-management/networks/nsx/projects/{project}/vpc-connectivity-profiles* can be used to list VPCConnectivityProfiles for a Project.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, use the default VPC Connectivity Profile as defined in *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.VpcNetwork.nsx_project*. | [optional] 
**DefaultPrivateCidrs** | [**List&lt;VcenterNamespaceManagementNetworksIpv4Cidr&gt;**](VcenterNamespaceManagementNetworksIpv4Cidr.md) | *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.VpcNetwork.default_private_cidrs* specifies CIDR blocks from which private subnets are allocated. This range must not overlap with those in *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.VpcNetwork.vpc_connectivity_profile*, *Vcenter.NamespaceManagement.Clusters.EnableSpec.service_cidr*, or other services running in the datacenter. You must set at least one CIDR of size 16 or larger to enable a Supervisor with VPC networking. If Avi is used, another CIDR of size 64 is needed.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

