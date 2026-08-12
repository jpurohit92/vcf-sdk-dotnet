# Vcenter.Automation.OpenApi.Model.VcenterNamespacesInstancesNetworkConfigUpdateSpec
The Vcenter.Namespaces.Instances.NetworkConfigUpdateSpec schema contains specifications required when updating the network configuration of a vSphere Namespaces object.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkProvider** | **string** | The network provider that manages the vSphere Namespaces network configuration.  Possible values:   - &#x60;NSXT_CONTAINER_PLUGIN&#x60;: Network provider is NSX Container Plugin.   - &#x60;VSPHERE_NETWORK&#x60;: Network provider is vSphere Networking.   - &#x60;NSX_VPC&#x60;: Network provider is NSX VPC.  This constant was added in __vSphere API 9.0.0.0__.   For more information see: *Vcenter.Namespaces.Instances.NetworkProvider*.  This property was added in __vSphere API 9.0.0.0__. | 
**VpcConfig** | [**VcenterNamespacesInstancesVpcNetworkUpdateSpec**](VcenterNamespacesInstancesVpcNetworkUpdateSpec.md) | The network configuration for NSX VPC Namespaces, supported by *Vcenter.Namespaces.Instances.NetworkProvider.NSX_VPC* network provider.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of network_provider is *Vcenter.Namespaces.Instances.NetworkProvider.NSX_VPC*. | [optional] 
**VsphereNetworkConfig** | [**VcenterNamespacesInstancesVsphereNetworkConfigUpdateSpec**](VcenterNamespacesInstancesVsphereNetworkConfigUpdateSpec.md) | The network configuration specific to *Vcenter.Namespaces.Instances.NetworkProvider.VSPHERE_NETWORK* provider.  This property was added in __vSphere API 9.1.0.0__.  This property is optional and it is only relevant when the value of network_provider is *Vcenter.Namespaces.Instances.NetworkProvider.VSPHERE_NETWORK*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

