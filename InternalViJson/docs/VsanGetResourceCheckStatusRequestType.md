# Vcenter.ViJson.OpenApi.Model.VsanGetResourceCheckStatusRequestType
The parameters of *VsanResourceCheckSystem.VsanGetResourceCheckStatus*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResourceCheckSpec** | [**VsanResourceCheckSpec**](VsanResourceCheckSpec.md) | The specification of the resource check to be queried. If it is not specified, *VsanResourceCheckStatus* will still be returned with *VsanResourceCheckStatus.task* and/or *VsanResourceCheckStatus.parentTask* information if such task is running in the specified cluster. However, *VsanResourceCheckStatus.result* will not be populated in this case.  | [optional] 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster to fetch the resource check status.  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

