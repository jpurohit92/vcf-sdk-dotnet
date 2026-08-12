# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksUpdateSpec
The Vcenter.NamespaceManagement.Networks.UpdateSpec schema contains the specification required to update the configuration of a vSphere Namespaces network object. This schema is applied partially, and only the specified fields will replace or modify their existing counterparts.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkProvider** | **string** | The network provider that will manage the vSphere Namespaces network object.  Possible values:   - &#x60;NSXT_CONTAINER_PLUGIN&#x60;: NSX Container Plugin.   - &#x60;VSPHERE_NETWORK&#x60;: vSphere Networking.  This constant was added in __vSphere API 7.0.1.0__.   - &#x60;NSX_VPC&#x60;: NSX VPC.  This constant was added in __vSphere API 9.0.0.0__.   For more information see: *Vcenter.NamespaceManagement.Clusters.NetworkProvider*.  This property was added in __vSphere API 7.0.3.0__. | 
**VsphereNetwork** | [**VcenterNamespaceManagementNetworksVsphereDVPGNetworkUpdateSpec**](VcenterNamespaceManagementNetworksVsphereDVPGNetworkUpdateSpec.md) | Updated configuration specification for a DVPG-backed Namespaces network object, supported by *Vcenter.NamespaceManagement.Clusters.NetworkProvider.VSPHERE_NETWORK* network provider.  This property was added in __vSphere API 7.0.3.0__.  This property is optional and it is only relevant when the value of network_provider is *Vcenter.NamespaceManagement.Clusters.NetworkProvider.VSPHERE_NETWORK*. | [optional] 
**NsxNetwork** | [**VcenterNamespaceManagementNetworksNsxNetworkUpdateSpec**](VcenterNamespaceManagementNetworksNsxNetworkUpdateSpec.md) | Updated configuration specification for a NSXT-backed Namespaces network configuration, supported by *Vcenter.NamespaceManagement.Clusters.NetworkProvider.NSXT_CONTAINER_PLUGIN* network provider.  This property was added in __vSphere API 7.0.2.0__.  This property is optional and it is only relevant when the value of network_provider is *Vcenter.NamespaceManagement.Clusters.NetworkProvider.NSXT_CONTAINER_PLUGIN*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

