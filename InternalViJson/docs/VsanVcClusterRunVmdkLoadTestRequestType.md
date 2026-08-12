# Vcenter.ViJson.OpenApi.Model.VsanVcClusterRunVmdkLoadTestRequestType
The parameters of *VsanVcClusterHealthSystem.VsanVcClusterRunVmdkLoadTest*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target vCenter cluster.  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | 
**Runname** | **string** | The name for this test.  | 
**DurationSec** | **int** | The duration time for each of VMDK load test.  | [optional] 
**Specs** | [**List&lt;VsanVmdkLoadTestSpec&gt;**](VsanVmdkLoadTestSpec.md) |  | [optional] 
**Action** | **string** | The possible actions are \&quot;prepare\&quot;, \&quot;run\&quot; and \&quot;cleanup\&quot; and \&quot;fullrun\&quot;. Default is \&quot;fullrun\&quot;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

