# Vcenter.Automation.OpenApi.Model.VcenterNamespacesInstancesVpcNetworkInfo
The Vcenter.Namespaces.Instances.VpcNetworkInfo schema describes the specification of a VPC network configuration.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VpcConfig** | [**VcenterNamespacesInstancesVpcConfig**](VcenterNamespacesInstancesVpcConfig.md) | VPC configuration used for this vSphere Namespace.  This property was added in __vSphere API 9.0.0.0__. | 
**Vpc** | **string** | NSX path of the VPC associated with this vSphere Namespace.  This property was added in __vSphere API 9.0.0.0__. | 
**SharedSubnets** | [**List&lt;VcenterNamespacesInstancesSharedSubnet&gt;**](VcenterNamespacesInstancesSharedSubnet.md) | Subnets created outside of the Supervisor associated with this vSphere Namespace.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**AutoCreated** | **bool** | Whether the VPC is automatically created for the vSphere Namespace.  This property was added in __vSphere API 9.0.0.0__. | 
**DefaultSubnetSize** | **long** | Default size of vSphere Namespace Subnets.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

