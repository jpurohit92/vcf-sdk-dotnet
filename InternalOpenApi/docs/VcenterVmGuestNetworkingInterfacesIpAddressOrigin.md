# Vcenter.Automation.OpenApi.Model.VcenterVmGuestNetworkingInterfacesIpAddressOrigin
The Vcenter.Vm.Guest.Networking.Interfaces.IpAddressOrigin enumerated type specifies how an IP address was obtained for an interface. See RFC 4293 IpAddressOriginTC.  Possible values:   - `OTHER`: Any other type of address configuration other than the below mentioned ones will fall under this category. For e.g., automatic address configuration for the link local address falls under this type.   - `MANUAL`: The address is configured manually.   - `DHCP`: The address is configured through dhcp.   - `LINKLAYER`: The address is obtained through stateless autoconfiguration (autoconf). See RFC 4862, IPv6 Stateless Address Autoconfiguration.   - `RANDOM`: The address is chosen by the system at random e.g., an IPv4 address within 169.254/16, or an RFC 3041 privacy address.   This enumeration was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

