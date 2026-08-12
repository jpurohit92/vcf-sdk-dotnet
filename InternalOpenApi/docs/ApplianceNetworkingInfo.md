# Vcenter.Automation.OpenApi.Model.ApplianceNetworkingInfo
The Appliance.Networking.Info schema contains information about the network configuration of a virtual appliance.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dns** | [**ApplianceNetworkingDnsInfo**](ApplianceNetworkingDnsInfo.md) | DNS configuration.  This property was added in __vSphere API 6.7__. | 
**Interfaces** | [**Dictionary&lt;string, ApplianceNetworkingInterfacesInterfaceInfo&gt;**](ApplianceNetworkingInterfacesInterfaceInfo.md) | Interface configuration as a key-value map where key is a network interface name, for example, \&quot;nic0\&quot;.  This property was added in __vSphere API 6.7__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.appliance.networking.interfaces&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.appliance.networking.interfaces&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

