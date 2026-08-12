# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksIPManagement
Vcenter.NamespaceManagement.Networks.IPManagement schema dictates IP addressing configuration for the network that hosts the Supervisor.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DhcpEnabled** | **bool** | *Vcenter.NamespaceManagement.Networks.IPManagement.dhcp_enabled* If set true, configures IP address using the DHCP server on the broadcast domain unless the corresponding *Vcenter.NamespaceManagement.Networks.IPManagement.ip_assignments* are set.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60; this field defaults to true. | [optional] 
**GatewayAddress** | **string** | *Vcenter.NamespaceManagement.Networks.IPManagement.gateway_address* is the IP address combined with the subnet prefix length (e.g. 192.168.1.1/24) of the default gateway of this network.  This property was added in __vSphere API 8.0.0.1__.  If *Vcenter.NamespaceManagement.Networks.IPManagement.dhcp_enabled* is not set, or this is an NSX network, this address must be set. | [optional] 
**IpAssignments** | [**List&lt;VcenterNamespaceManagementNetworksIPAssignment&gt;**](VcenterNamespaceManagementNetworksIPAssignment.md) | *Vcenter.NamespaceManagement.Networks.IPManagement.ip_assignments* are a list of roles that can be allocated to IP addresses. If *Vcenter.NamespaceManagement.Networks.IPManagement.gateway_address* is specified, these assignments must be on the same subnet.  This property was added in __vSphere API 8.0.0.1__.  These assignments are optional when using DHCP. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

