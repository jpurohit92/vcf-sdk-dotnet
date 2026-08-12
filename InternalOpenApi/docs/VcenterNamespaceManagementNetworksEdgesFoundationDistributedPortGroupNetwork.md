# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksEdgesFoundationDistributedPortGroupNetwork
Vcenter.NamespaceManagement.Networks.Edges.Foundation.DistributedPortGroupNetwork is a network backed by a single vSphere distributed port group.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The user-facing name of the network. A Supervisor workload network will be created with this name. This name must be compliant with DNS naming specifications as stated in RFC 1123.  This property was added in __vSphere API 9.0.0.0__. | 
**Network** | **string** | Distributed Virtual Port Group identifier.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;vSphereDistributedPortGroup&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;vSphereDistributedPortGroup&#x60;. | 
**Ipam** | **string** | IP Address management scheme for this network.  Possible values:   - &#x60;STATIC&#x60;: IP addresses are statically allocated.   - &#x60;DHCP&#x60;: IP addresses are acquired through a DHCP server via the DHCP protocol.   For more information see: *Vcenter.NamespaceManagement.Networks.Edges.Foundation.DistributedPortGroupNetwork.IPAMType*.  This property was added in __vSphere API 9.0.0.0__. | 
**IpConfig** | [**VcenterNamespaceManagementNetworksEdgesFoundationIPConfig**](VcenterNamespaceManagementNetworksEdgesFoundationIPConfig.md) | Configuration used to configure static IP addresses.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of ipam is *Vcenter.NamespaceManagement.Networks.Edges.Foundation.DistributedPortGroupNetwork.IPAMType.STATIC*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

