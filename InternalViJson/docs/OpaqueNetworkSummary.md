# Vcenter.ViJson.OpenApi.Model.OpaqueNetworkSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Network** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to the associated managed object.  Refers instance of *Network*.  | [optional] 
**Name** | **string** | Name of the network.  | 
**Accessible** | **bool** | At least one host is configured to provide this network.  | 
**IpPoolName** | **string** | Name of the associated IP pool.  Empty if the network is not associated with an IP pool.  | 
**IpPoolId** | **int** | Identifier of the associated IP pool.  Zero if the network is not associated with an IP pool.  | [optional] 
**OpaqueNetworkId** | **string** | The opaque network ID  | 
**OpaqueNetworkType** | **string** | The opaque network type  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

