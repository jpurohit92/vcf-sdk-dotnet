# Vcenter.ViJson.OpenApi.Model.PhysicalNicCdpInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CdpVersion** | **int** | CDP version.  The value is always 1.  | [optional] 
**Timeout** | **int** | This is the periodicity of advertisement, the time between two successive CDP message transmissions  | [optional] 
**Ttl** | **int** | Time-To-Live.  the amount of time, in seconds, that a receiver should retain the information contained in the CDP packet.  | [optional] 
**Samples** | **int** | The number of CDP messages we have received from the device.  | [optional] 
**DevId** | **string** | Device ID which identifies the device.  By default, the device ID is either the device&#39;s fully-qualified host name (including the domain name) or the device&#39;s hardware serial number in ASCII.  | [optional] 
**Address** | **string** | The advertised IP address that is assigned to the interface of the device on which the CDP message is sent.  The device can advertise all addresses for a given protocol suite and, optionally, can advertise one or more loopback IP addresses. But this property only show the first address.  | [optional] 
**PortId** | **string** | Port ID.  An ASCII character string that identifies the port on which the CDP message is sent, e.g. \&quot;FastEthernet0/8\&quot;  | [optional] 
**DeviceCapability** | [**PhysicalNicCdpDeviceCapability**](PhysicalNicCdpDeviceCapability.md) | Device Capability *PhysicalNicCdpDeviceCapability*  | [optional] 
**SoftwareVersion** | **string** | Software version on the device.  A character string that provides information about the software release version that the device is running. e.g. \&quot;Cisco Internetwork Operating Syscisco WS-C2940-8TT-S\&quot;  | [optional] 
**HardwarePlatform** | **string** | Hardware platform.  An ASCII character string that describes the hardware platform of the device , e.g. \&quot;cisco WS-C2940-8TT-S\&quot;  | [optional] 
**IpPrefix** | **string** | IP prefix.  Each IP prefix represents one of the directly connected IP network segments of the local route.  | [optional] 
**IpPrefixLen** | **int** | ipPrefix length.  | [optional] 
**Vlan** | **int** | The native VLAN of advertising port.  The native VLAN is the VLAN to which a port returns when it is not trunking. Also, the native VLAN is the untagged VLAN on an 802.1Q trunk.  | [optional] 
**FullDuplex** | **bool** | Half/full duplex setting of the advertising port.  | [optional] 
**Mtu** | **int** | MTU, the maximum transmission unit for the advertising port.  Possible values are 1500 through 18190.  | [optional] 
**SystemName** | **string** | The configured SNMP system name of the device.  | [optional] 
**SystemOID** | **string** | The configured SNMP system OID of the device.  | [optional] 
**MgmtAddr** | **string** | The configured IP address of the SNMP management interface for the device.  | [optional] 
**Location** | **string** | The configured location of the device.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

