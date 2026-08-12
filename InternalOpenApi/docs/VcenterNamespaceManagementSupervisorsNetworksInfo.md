# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsNetworksInfo
The Vcenter.NamespaceManagement.Supervisors.Networks.Info schema contains detailed information about a specific Supervisor network.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkProvider** | **string** | The network provider that will manage the Supervisor network object.  Possible values:   - &#x60;VSPHERE_NETWORK&#x60;: Provider for vSphere Networking.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Networks.NetworkProvider*.  This property was added in __vSphere API 9.1.0.0__. | 
**VsphereNetwork** | [**VcenterNamespaceManagementSupervisorsNetworksVsphereDVPGNetworkInfo**](VcenterNamespaceManagementSupervisorsNetworksVsphereDVPGNetworkInfo.md) | Updated configuration specification for a DVPG-backed Supervisor network object, supported by *Vcenter.NamespaceManagement.Supervisors.Networks.NetworkProvider.VSPHERE_NETWORK* network provider.  This property was added in __vSphere API 9.1.0.0__.  This property is optional and it is only relevant when the value of network_provider is *Vcenter.NamespaceManagement.Supervisors.Networks.NetworkProvider.VSPHERE_NETWORK*. | [optional] 
**Namespaces** | **List&lt;string&gt;** | A list of Supervisor Namespaces associated with this network.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.namespaces.Instance&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.namespaces.Instance&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

