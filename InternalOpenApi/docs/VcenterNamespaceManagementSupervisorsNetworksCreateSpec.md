# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsNetworksCreateSpec
The Vcenter.NamespaceManagement.Supervisors.Networks.CreateSpec schema contains the specification required to create a Supervisor network object.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Network** | **string** | Identifier of the network. This must be a valid DNS subdomain name as defined in [RFC 1123](https://tools.ietf.org/html/rfc1123). It must: - have a maximum length of 253 characters - contain only lowercase alphanumeric characters, &#39;-&#39;, or &#39;.&#39; - start and end with an alphanumeric character This name must also be unique within a Supervisor.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.Network&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.Network&#x60;. | 
**NetworkProvider** | **string** | The network provider that will manage the Supervisor.  Possible values:   - &#x60;VSPHERE_NETWORK&#x60;: Provider for vSphere Networking.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Networks.NetworkProvider*.  This property was added in __vSphere API 9.1.0.0__. | 
**VsphereNetwork** | [**VcenterNamespaceManagementSupervisorsNetworksVsphereDVPGNetworkCreateSpec**](VcenterNamespaceManagementSupervisorsNetworksVsphereDVPGNetworkCreateSpec.md) | The create spec for a DVPG-backed Supervisor network object, supported by *Vcenter.NamespaceManagement.Supervisors.Networks.NetworkProvider.VSPHERE_NETWORK* network provider.  This property was added in __vSphere API 9.1.0.0__.  This property is optional and it is only relevant when the value of network_provider is *Vcenter.NamespaceManagement.Supervisors.Networks.NetworkProvider.VSPHERE_NETWORK*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

