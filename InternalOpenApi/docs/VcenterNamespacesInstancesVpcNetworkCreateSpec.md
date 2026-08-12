# Vcenter.Automation.OpenApi.Model.VcenterNamespacesInstancesVpcNetworkCreateSpec
The Vcenter.Namespaces.Instances.VpcNetworkCreateSpec schema describes the specification of a NSX VPC namespace Network configuration.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VpcConfig** | [**VcenterNamespacesInstancesVpcConfig**](VcenterNamespacesInstancesVpcConfig.md) | NSX VPC properties. If set, and *Vcenter.Namespaces.Instances.VpcNetworkCreateSpec.vpc* is missing or &#x60;null&#x60;, a VPC will be automatically created by Supervisor. The VPC will be scoped to this particular namespace (cannot be consumed by other namespaces). The VPC will be created with *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.VpcNetwork.nsx_project* and *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.VpcNetwork.vpc_connectivity_profile*, and NSX Load Balancer size of SMALL if NSX LB provider is used.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, a pre-created VPC can be used. | [optional] 
**Vpc** | **string** | NSX path of the pre-created VPC. If set, values set in *Vcenter.Namespaces.Instances.VpcNetworkCreateSpec.vpc_config* will be ignored.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, a VPC will be created automatically using properties in *Vcenter.Namespaces.Instances.VpcNetworkCreateSpec.vpc_config*. | [optional] 
**SharedSubnets** | [**List&lt;VcenterNamespacesInstancesSharedSubnet&gt;**](VcenterNamespacesInstancesSharedSubnet.md) | Subnets created outside of the Supervisor to be associated with this vSphere Namespace.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**DefaultSubnetSize** | **long** | Default size of vSphere Namespace Subnets.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, a default Subnet size of /27 (or 32 addresses) is set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

