# Vcenter.Automation.OpenApi.Model.VcenterVmGuestNetworkingInterfacesIpAddressStatus
The Vcenter.Vm.Guest.Networking.Interfaces.IpAddressStatus enumerated type defines the present status of an address on an interface. See RFC 4293 IpAddressStatusTC.  Possible values:   - `PREFERRED`: Indicates that this is a valid address.   - `DEPRECATED`: Indicates that this is a valid but deprecated address that should no longer be used as a source address.   - `INVALID`: Indicates that this isn't a valid address.   - `INACCESSIBLE`: Indicates that the address is not accessible because interface is not operational.   - `UNKNOWN`: Indicates that the status cannot be determined.   - `TENTATIVE`: Indicates that the uniqueness of the address on the link is presently being verified.   - `DUPLICATE`: Indicates the address has been determined to be non-unique on the link, this address will not be reachable.   This enumeration was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

