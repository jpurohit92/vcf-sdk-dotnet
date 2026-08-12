# Vcenter.ViJson.OpenApi.Model.DvsIpNetworkRuleQualifier

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key of the Qualifier  | [optional] 
**SourceAddress** | [**IpAddress**](IpAddress.md) | IP qualifier for source.  If this property is NULL, it will match \&quot;any IPv4 or any IPv6 address\&quot;.  | [optional] 
**DestinationAddress** | [**IpAddress**](IpAddress.md) | IP qualifier for destination.  If this property is NULL, it will match \&quot;any IPv4 or any IPv6 address\&quot;.  | [optional] 
**Protocol** | [**IntExpression**](IntExpression.md) | Protocols like TCP, UDP, ICMP etc.  The valid value for a protocol is got from IANA assigned value for the protocol. This can be got from RFC 5237 and IANA website section related to protocol numbers.  | [optional] 
**SourceIpPort** | [**DvsIpPort**](DvsIpPort.md) | Source IP Port.  | [optional] 
**DestinationIpPort** | [**DvsIpPort**](DvsIpPort.md) | Destination IP Port.  | [optional] 
**TcpFlags** | [**IntExpression**](IntExpression.md) | TCP flags.  The valid values can be found at RFC 3168. TCP flags are not supported by Traffic Filtering  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

