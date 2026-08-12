# Vcenter.ViJson.OpenApi.Model.DestroyIpPoolRequestType
The parameters of *IpPoolManager.DestroyIpPool*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dc** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datacenter on which to find the pool  ***Required privileges:*** Datacenter.IpPoolConfig  Refers instance of *Datacenter*.  | 
**Id** | **int** | The unique ID of the pool  | 
**Force** | **bool** | If true, the pool will be destroyed even if it is in use  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

