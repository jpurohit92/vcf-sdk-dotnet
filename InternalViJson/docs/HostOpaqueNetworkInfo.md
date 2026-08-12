# Vcenter.ViJson.OpenApi.Model.HostOpaqueNetworkInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DynamicProperty** | [**List&lt;DynamicProperty&gt;**](DynamicProperty.md) | Set of dynamic properties.  This property is optional because only the properties of an object that are unknown to a client will be part of this set. This property is not readonly just in case we want to send such properties from a client in the future.  | [optional] 
**OpaqueNetworkId** | **string** | The ID of the opaque network.  | 
**OpaqueNetworkName** | **string** | The name of the opaque network.  | 
**OpaqueNetworkType** | **string** | The type of the opaque network.  | 
**PnicZone** | **List&lt;string&gt;** | IDs of networking zones that back the opaque network.  | [optional] 
**Capability** | [**OpaqueNetworkCapability**](OpaqueNetworkCapability.md) | The capability of the opaque network.  Refer *OpaqueNetworkCapability*  | [optional] 
**ExtraConfig** | [**List&lt;OptionValue&gt;**](OptionValue.md) | Extra NSX specific properties for opaque networks.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

