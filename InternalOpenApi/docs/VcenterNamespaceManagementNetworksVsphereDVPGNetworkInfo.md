# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksVsphereDVPGNetworkInfo
The Vcenter.NamespaceManagement.Networks.VsphereDVPGNetworkInfo schema describes the configuration specification of a vSphere DVPG-backed Namespaces Network object.  This schema was added in __vSphere API 7.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Portgroup** | **string** | Identifier of the vSphere Distributed Portgroup backing the vSphere network object.  This property was added in __vSphere API 7.0.1.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Network&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Network&#x60;. | 
**IpAssignmentMode** | **string** | IP address assignment mode.  Possible values:   - &#x60;DHCP&#x60;: The address is automatically assigned by a DHCP server.   - &#x60;STATICRANGE&#x60;: The address is assigned from a static range.   - &#x60;NONE&#x60;: The address assignment is not managed by the Supervisor. This mode is suitable for L2 network requirements or scenarios requiring manual IP configurations.  This constant was added in __vSphere API 9.1.0.0__.   For more information see: *Vcenter.NamespaceManagement.Networks.IPAssignmentMode*.  This property was added in __vSphere API 7.0.3.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**AddressRanges** | [**List&lt;VcenterNamespaceManagementIPRange&gt;**](VcenterNamespaceManagementIPRange.md) | Usable IP pools on this network.  This property was added in __vSphere API 7.0.1.0__. | 
**Gateway** | **string** | Gateway for the network.  This property was added in __vSphere API 7.0.1.0__. | 
**SubnetMask** | **string** | Subnet mask of the network.  This property was added in __vSphere API 7.0.1.0__. | 
**Mode** | **string** | Displays the intended use of the network.  Possible values:   - &#x60;MANAGEMENT&#x60;: Indicates the infrastructure supports connectivity between this network and the Supervisor management network. Entities on this network are capable of communicating with management entities like the Supervisor and vCenter Server.    Networks can only be associated to *Vcenter.NamespaceManagement.Networks.Mode.MANAGEMENT* networks when the Supervisor management network is configured to be the Primary Workload Network.   - &#x60;WORKLOAD&#x60;: Indicates the network is intended for general workload consumption. This network should generally not be routable to networks with the *Vcenter.NamespaceManagement.Networks.Mode.MANAGEMENT* mode set.   For more information see: *Vcenter.NamespaceManagement.Networks.Mode*.  This property was added in __vSphere API 9.0.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

