# Vcenter.ViJson.OpenApi.Model.VsanQueryVcClusterVmdkLoadHistoryTestRequestType
The parameters of *VsanVcClusterHealthSystem.VsanQueryVcClusterVmdkLoadHistoryTest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The vCenter cluster  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | 
**Count** | **int** | Collect the last test data for the given number at most. Default to get the latest one historical data.  | [optional] 
**TaskId** | **string** | The task Id which run the VMDK performance test. Default is None The count parameter will be ignored when the taskId is not None  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

