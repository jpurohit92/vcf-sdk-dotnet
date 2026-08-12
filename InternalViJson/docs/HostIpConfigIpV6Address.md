# Vcenter.ViJson.OpenApi.Model.HostIpConfigIpV6Address

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpAddress** | **string** | The ipv6 address.  When DHCP is enabled, this property reflects the current IP configuration and cannot be set.  | 
**PrefixLength** | **int** | The prefix length.  An ipv6 prefixLength is a decimal value that indicates the number of contiguous, higher-order bits of the address that make up the network portion of the address. For example, 10FA:6604:8136:6502::/64 is a possible IPv6 prefix. The prefix length in this case is 64.  | 
**Origin** | **string** | The type of the ipv6 address configuration on the interface.  This can be one of the types defined my the enum *HostIpConfigIpV6AddressConfigType_enum*.  | [optional] 
**DadState** | **string** | The state of this ipAddress.  Can be one of *HostIpConfigIpV6AddressStatus_enum*  | [optional] 
**Lifetime** | **DateTime** | The time when will this address expire.  If not set the address lifetime is unlimited.  | [optional] 
**Operation** | **string** | Valid values are \&quot;add\&quot; and \&quot;remove\&quot;.  See *HostConfigChangeOperation_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

