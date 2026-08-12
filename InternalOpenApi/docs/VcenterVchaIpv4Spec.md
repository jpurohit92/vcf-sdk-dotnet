# Vcenter.Automation.OpenApi.Model.VcenterVchaIpv4Spec
The Vcenter.Vcha.Ipv4Spec schema contains IPV4 information used to configure a network interface.  This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | IPV4 address to be used to configure the interface.  This property was added in __vSphere API 6.7.1__. | 
**SubnetMask** | **string** | The subnet mask for the interface.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60; and the prefix property is missing or &#x60;null&#x60;, then an error will be reported.    If missing or &#x60;null&#x60; and the prefix property is set, then the prefix property will be used to create a subnet mask whose first prefix bits are 1 and the remaining bits 0.    If both the subnet_mask property and the prefix property are set and they do not represent the same value, then an error will be reported. | [optional] 
**Prefix** | **long** | The CIDR prefix for the interface.  This property was added in __vSphere API 6.7.1__.  If missing or &#x60;null&#x60; and the subnet_mask property is missing or &#x60;null&#x60;, this an error will be reported.    If missing or &#x60;null&#x60; and the subnet_mask property is set, then the subnet_mask property will be used.    If both the subnet_mask property and the prefix property are set and they do not represent the same value, then an error will be reported. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

