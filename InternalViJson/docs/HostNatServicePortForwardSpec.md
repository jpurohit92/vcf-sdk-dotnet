# Vcenter.ViJson.OpenApi.Model.HostNatServicePortForwardSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Either \&quot;tcp\&quot; or \&quot;udp\&quot;.  | 
**Name** | **string** | The user-defined name to identify the service being forwarded.  No white spaces are allowed in the string.  | 
**HostPort** | **int** | The port number on the host.  Network traffic sent to the host on this TCP/UDP port is forwarded to the guest at the specified IP address and port.  | 
**GuestPort** | **int** | The port number for the guest.  Network traffic from the host is forwarded to this port.  | 
**GuestIpAddress** | **string** | The IP address for the guest.  Network traffic from the host is forwarded to this IP address.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

