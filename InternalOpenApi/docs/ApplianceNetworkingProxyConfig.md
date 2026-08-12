# Vcenter.Automation.OpenApi.Model.ApplianceNetworkingProxyConfig
The Appliance.Networking.Proxy.Config schema defines proxy configuration.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Server** | **string** | URL of the proxy server  This property was added in __vSphere API 6.7__. | 
**Port** | **long** | Port to connect to the proxy server. In a &#39;get&#39; call, indicates the port connected to the proxy server. In a &#39;set&#39; call, specifies the port to connect to the proxy server. A value of -1 indicates the default port.  This property was added in __vSphere API 6.7__. | 
**Username** | **string** | Username for proxy server.  This property was added in __vSphere API 6.7__.  Only set if proxy requires username. | [optional] 
**Password** | **string** | Password for proxy server.  This property was added in __vSphere API 6.7__.  Only set if proxy requires password. | [optional] 
**Enabled** | **bool** | In the result of the #get and #list operations this property indicates whether proxying is enabled for a particular protocol. In the input to the test and set operations this property specifies whether proxying should be enabled for a particular protocol.  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

