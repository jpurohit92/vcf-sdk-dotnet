# Vcenter.ViJson.OpenApi.Model.HostInternetScsiHbaIscsiIpv6Address

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | IPv6 address.  | 
**PrefixLength** | **int** | IPv6 address prefix length.  | 
**Origin** | **string** | Type of the address.  See { @Vim::Host::HostBusAdapter::IscsiIpv6Address::AddressConfigurationType }. Note: While setting IPv6 address, value of origin should be set to static.  | 
**Operation** | **string** | Operation to be performed with the IP address.  See { @Vim::Host::HostBusAdapter::IscsiIpv6Address::IPv6AddressOperation }. Note: This field/operation is used only while setting the IPProperties on host bus adapter. This field would not have any value (Unset) while viewing IPProperties of the host bus adapter.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

