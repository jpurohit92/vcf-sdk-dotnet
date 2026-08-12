# Vcenter.Automation.OpenApi.Model.VcenterVmGuestNetworkingInterfacesIpConfigInfo
The Vcenter.Vm.Guest.Networking.Interfaces.IpConfigInfo schema describes the protocol version independent address reporting data object for network interfaces.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpAddresses** | [**List&lt;VcenterVmGuestNetworkingInterfacesIpAddressInfo&gt;**](VcenterVmGuestNetworkingInterfacesIpAddressInfo.md) | IP addresses configured on the interface.  This property was added in __vSphere API 7.0.0.0__. | 
**Dhcp** | [**VcenterVmGuestDhcpConfigInfo**](VcenterVmGuestDhcpConfigInfo.md) | Client side DHCP for an interface.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; the IP was not configured by DHCP. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

