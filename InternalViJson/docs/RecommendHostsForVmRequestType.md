# Vcenter.ViJson.OpenApi.Model.RecommendHostsForVmRequestType
The parameters of *ClusterComputeResource.RecommendHostsForVm*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Specifies the virtual machine for which the user is requesting a recommendations.  Refers instance of *VirtualMachine*.  | 
**Pool** | [**ManagedObjectReference**](ManagedObjectReference.md) | Specifies the ResourcePool into which the virtual machine is to be migrated. If the virtual machine is powered-on, this argument must be specified and it is relevant only when the virtual machine is powered-on. This ResourcePool cannot be in the same cluster as the virtual machine.  Refers instance of *ResourcePool*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

