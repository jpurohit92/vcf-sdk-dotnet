# Vcenter.ViJson.OpenApi.Model.VsanClusterVmdkLoadTestResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Task** | [**ManagedObjectReference**](ManagedObjectReference.md) | The VC task associates with this test result  Refers instance of *Task*.  | [optional] 
**ClusterResult** | [**VsanClusterProactiveTestResult**](VsanClusterProactiveTestResult.md) | The overall vSAN cluster result for VMDK workload test.  The cluster result will be empty when the task is running.  | [optional] 
**HostResults** | [**List&lt;VsanHostVmdkLoadTestResult&gt;**](VsanHostVmdkLoadTestResult.md) | The VMDK load test result for each of host.  The host result will be empty when the task is running.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

