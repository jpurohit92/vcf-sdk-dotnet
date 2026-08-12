# Vcenter.Automation.OpenApi.Model.VcenterOvfsNetworkInfo
The Vcenter.Ovfs.NetworkInfo schema defines network information for specifying network mappings from the OVF descriptor to a Network in the inventory.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetType** | **string** | Type for the network.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be one of &#x60;DistributedVirtualPortgroup&#x60;, &#x60;Network&#x60;, or &#x60;OpaqueNetwork&#x60;. When operations return a value of this schema as a response, the property will be one of &#x60;DistributedVirtualPortgroup&#x60;, &#x60;Network&#x60;, or &#x60;OpaqueNetwork&#x60;. | 
**Network** | **string** | The identifier of the network in the inventory that is the target of the OVF network.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for one of these resource types: &#x60;DistributedVirtualPortgroup&#x60;, &#x60;Network&#x60;, or &#x60;OpaqueNetwork&#x60;. When operations return a value of this schema as a response, the property will be an identifier for one of these resource types: &#x60;DistributedVirtualPortgroup&#x60;, &#x60;Network&#x60;, or &#x60;OpaqueNetwork&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

