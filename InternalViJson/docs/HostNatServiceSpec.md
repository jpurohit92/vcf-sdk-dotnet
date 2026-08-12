# Vcenter.ViJson.OpenApi.Model.HostNatServiceSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VirtualSwitch** | **string** | The name of the virtual switch to which nat service is connected.  | 
**ActiveFtp** | **bool** | The flag to indicate whether or not non-passive mode FTP connections should be allowed.  | 
**AllowAnyOui** | **bool** | The flag to indicate whether or not the NAT Service allows media access control traffic from any Organizational Unique Identifier (OUI)? By default, it does not allow traffic that originated from the host to avoid packet loops.  | 
**ConfigPort** | **bool** | The flag to indicate whether or not the NAT Service should open a configuration port.  | 
**IpGatewayAddress** | **string** | The IP address that the NAT Service should use on the virtual network.  | 
**UdpTimeout** | **int** | The time allotted for UDP packets.  | 
**PortForward** | [**List&lt;HostNatServicePortForwardSpec&gt;**](HostNatServicePortForwardSpec.md) | The port forwarding specifications to allow network connections to be initiated from outside the firewall.  | [optional] 
**NameService** | [**HostNatServiceNameServiceSpec**](HostNatServiceNameServiceSpec.md) | The configuration of naming services.  These parameters are specific to Windows.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

