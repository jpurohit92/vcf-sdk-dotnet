# Vcenter.ViJson.OpenApi.Model.NetDhcpConfigInfoDhcpOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enable** | **bool** | Report state of dhcp client services.  | 
**Config** | [**List&lt;KeyValue&gt;**](KeyValue.md) | Platform specific settings for DHCP Client.  The key part is a unique number, the value part is the platform specific configuration command. For example on Linux, BSD systems using the file dhclient.conf output would be reported at system scope: key&#x3D;&#39;1&#39;, value&#x3D;&#39;timeout 60;&#39; key&#x3D;&#39;2&#39;, value&#x3D;&#39;reboot 10;&#39; output reported at per interface scope: key&#x3D;&#39;1&#39;, value&#x3D;&#39;prepend domain-name-servers 192.0.2.1;&#39; key&#x3D;&#39;2&#39;, value&#x3D;&#39;require subnet-mask, domain-name-servers;&#39;  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

