# Vcenter.ViJson.OpenApi.Model.VsanClusterVMsHealthSummaryResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumVMs** | **int** | Number of VMs that have this health status.  | 
**State** | **string** | The VM health state.  All of possible state include &#39;green&#39;, &#39;yellow&#39;, &#39;red&#39; and &#39;info&#39;  | [optional] 
**Health** | **string** | The VM state in vSAN cluster.  The VM state is computed by fetching the most severe state of virtual disk in this VM. All of possible states with severity order include &#39;inaccessible&#39;, &#39;reduced-availability-with-no-rebuild&#39;, &#39;reduced-availability-with-no-rebuild-delay-timer&#39;, &#39;reduced-availability-with-active-rebuild&#39;, &#39;data-move&#39;, &#39;non-availability-related-reconfig&#39;, &#39;non-availability-related-incompliance&#39; and &#39;healthy&#39;  | 
**VmInstanceUuids** | **List&lt;string&gt;** | instanceUuids of VM that have this health status.  Only included if query API requested it due to size.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

