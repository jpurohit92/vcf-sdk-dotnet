# Vcenter.Automation.OpenApi.Model.VcenterNamespacesInstancesVpcConfig
The Vcenter.Namespaces.Instances.VpcConfig schema describes the specification of a VPC for Namespaces Network configuration.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrivateCidrs** | [**List&lt;VcenterNamespacesInstancesIpv4Cidr&gt;**](VcenterNamespacesInstancesIpv4Cidr.md) | *Vcenter.Namespaces.Instances.VpcConfig.private_cidrs* specifies CIDR blocks from which private Subnets are allocated. This range should not overlap with those in *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.VpcNetwork.vpc_connectivity_profile*, *Vcenter.NamespaceManagement.Clusters.EnableSpec.service_cidr*, or other services running in the datacenter.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, use Supervisor default private CIDRs. This field must be (@term set) when Avi load balancer is used or when workloads are to be deployed on private Subnets. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

