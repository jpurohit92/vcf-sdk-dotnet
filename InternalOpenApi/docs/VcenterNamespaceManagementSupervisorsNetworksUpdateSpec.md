# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsNetworksUpdateSpec
The Vcenter.NamespaceManagement.Supervisors.Networks.UpdateSpec schema contains the specification required to update the configuration of a Supervisor network object. This schema is applied partially, and only the specified fields will replace or modify their existing counterparts.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkProvider** | **string** | The network provider that will manage the Supervisor network object.  Possible values:   - &#x60;VSPHERE_NETWORK&#x60;: Provider for vSphere Networking.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Networks.NetworkProvider*.  This property was added in __vSphere API 9.1.0.0__. | 
**VsphereNetwork** | [**VcenterNamespaceManagementSupervisorsNetworksVsphereDVPGNetworkUpdateSpec**](VcenterNamespaceManagementSupervisorsNetworksVsphereDVPGNetworkUpdateSpec.md) | Updated configuration specification for a DVPG-backed Supervisor network object, supported by *Vcenter.NamespaceManagement.Supervisors.Networks.NetworkProvider.VSPHERE_NETWORK* network provider.  This property was added in __vSphere API 9.1.0.0__.  This property is optional and it is only relevant when the value of network_provider is *Vcenter.NamespaceManagement.Supervisors.Networks.NetworkProvider.VSPHERE_NETWORK*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

