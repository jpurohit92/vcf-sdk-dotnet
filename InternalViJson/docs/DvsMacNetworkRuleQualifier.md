# Vcenter.ViJson.OpenApi.Model.DvsMacNetworkRuleQualifier

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key of the Qualifier  | [optional] 
**SourceAddress** | [**MacAddress**](MacAddress.md) | MAC address for source.  If this property is NULL, it will match \&quot;any MAC address\&quot;.  | [optional] 
**DestinationAddress** | [**MacAddress**](MacAddress.md) | MAC address for destination.  If this property is NULL, it will match \&quot;any MAC address\&quot;.  | [optional] 
**Protocol** | [**IntExpression**](IntExpression.md) | Protocol used.  This corresponds to the EtherType field in Ethernet frame. The valid values can be found from IEEE list at: http://standards.ieee.org/regauth/ as mentioned in RFC 5342.  | [optional] 
**VlanId** | [**IntExpression**](IntExpression.md) | vlan id.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

