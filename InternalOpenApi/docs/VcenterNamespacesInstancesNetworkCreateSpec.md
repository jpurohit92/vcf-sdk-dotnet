# Vcenter.Automation.OpenApi.Model.VcenterNamespacesInstancesNetworkCreateSpec
The Vcenter.Namespaces.Instances.NetworkCreateSpec schema contains the specification required to create a vSphere Namespaces network object.  This schema was added in __vSphere API 7.0.2.00100__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkProvider** | **string** | The network provider that will manage the vSphere Namespaces network object.  Possible values:   - &#x60;NSXT_CONTAINER_PLUGIN&#x60;: Network provider is NSX Container Plugin.   - &#x60;VSPHERE_NETWORK&#x60;: Network provider is vSphere Networking.   - &#x60;NSX_VPC&#x60;: Network provider is NSX VPC.  This constant was added in __vSphere API 9.0.0.0__.   For more information see: *Vcenter.Namespaces.Instances.NetworkProvider*.  This property was added in __vSphere API 7.0.2.00100__. | 
**Network** | [**VcenterNamespacesInstancesNsxNetworkCreateSpec**](VcenterNamespacesInstancesNsxNetworkCreateSpec.md) | The create spec for an NSXT-backed Namespaces network configuration, supported by *Vcenter.Namespaces.Instances.NetworkProvider.NSXT_CONTAINER_PLUGIN* network provider.  This property was added in __vSphere API 7.0.2.00100__.  This property is optional and it is only relevant when the value of network_provider is *Vcenter.Namespaces.Instances.NetworkProvider.NSXT_CONTAINER_PLUGIN*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

