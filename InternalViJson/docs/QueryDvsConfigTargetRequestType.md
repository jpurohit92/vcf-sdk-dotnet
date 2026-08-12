# Vcenter.ViJson.OpenApi.Model.QueryDvsConfigTargetRequestType
The parameters of *DistributedVirtualSwitchManager.QueryDvsConfigTarget*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host on which the query is to be made. If called directly on the host this parameter need not be specified.  Refers instance of *HostSystem*.  | [optional] 
**Dvs** | [**ManagedObjectReference**](ManagedObjectReference.md) | The distributed virtual switch on which the query is to be made. If unspecified the config target will encompass all the distributed virtual switches available on the host.  Refers instance of *DistributedVirtualSwitch*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

