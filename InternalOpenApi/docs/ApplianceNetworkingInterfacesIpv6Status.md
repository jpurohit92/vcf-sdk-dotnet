# Vcenter.Automation.OpenApi.Model.ApplianceNetworkingInterfacesIpv6Status
The Appliance.Networking.Interfaces.Ipv6.Status enumerated type defines IPv6 address status values. See RFC 4293.  Possible values:   - `TENTATIVE`: The IPv6 address is in the process of being verified as unique. An address in this state cannot be used for general communication. It can be used to determine the uniqueness of the address.   - `UNKNOWN`: The status of this address cannot be determined.   - `INACCESSIBLE`: The IPv6 address is inaccessible because the interface to which this address is assigned is not operational.   - `INVALID`: The IPv6 address is not a valid address. It should not appear as the destination or source address of a packet.   - `DUPLICATE`: The IPv6 address is not unique on the link and cannot be used.   - `PREFERRED`: This is a valid IPv6 address that can appear as the destination or source address of a packet.   - `DEPRECATED`: The is a valid but deprecated IPv6 address. This address cannot be used as a source address in new communications, although packets addressed to such an address are processed as expected.   - `OPTIMISTIC`: The IPv6 address is available for use, subject to restrictions, while its uniqueness on a link is being verified.   This enumeration was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

