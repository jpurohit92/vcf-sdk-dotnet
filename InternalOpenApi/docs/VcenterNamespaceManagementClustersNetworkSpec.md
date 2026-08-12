# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementClustersNetworkSpec
The Vcenter.NamespaceManagement.Clusters.NetworkSpec contains information related to network configuration for one or more interfaces.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FloatingIp** | **string** | Optionally specify the Floating IP used by the cluster control plane in case of DHCP.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the existing effective management network floating IP will be used. | [optional] 
**Network** | **string** | This property is deprecated as of __vSphere API 8.0.3.0__. Use *Vcenter.NamespaceManagement.Clusters.NetworkSpec.network_segment* instead.  Identifier for the network.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Network&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Network&#x60;. | 
**NetworkSegment** | [**VcenterNamespaceManagementSupervisorsNetworksNetworkSegment**](VcenterNamespaceManagementSupervisorsNetworksNetworkSegment.md) | Backing Network segment.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60;, *Vcenter.NamespaceManagement.Clusters.NetworkSpec.network* is used as the backing network. Otherwise, this value takes precedence over *Vcenter.NamespaceManagement.Clusters.NetworkSpec.network*. | [optional] 
**Mode** | **string** | The address assignment mode.  Possible values:   - &#x60;DHCP&#x60;: The address is automatically assigned by a DHCP server.   - &#x60;STATICRANGE&#x60;: The address is static.   For more information see: *Vcenter.NamespaceManagement.Clusters.NetworkSpec.Ipv4Mode*.  This property was added in __vSphere API 7.0.0.0__. | 
**AddressRange** | [**VcenterNamespaceManagementClustersIpv4Range**](VcenterNamespaceManagementClustersIpv4Range.md) | Settings for the interfaces on the network.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of mode is *Vcenter.NamespaceManagement.Clusters.NetworkSpec.Ipv4Mode.STATICRANGE*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

