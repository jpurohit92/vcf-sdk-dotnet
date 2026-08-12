# Vcenter.ViJson.OpenApi.Model.VsanClusterHealthQuerySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Task** | [**ManagedObjectReference**](ManagedObjectReference.md) | Task ID returned from API *VsanVcClusterHealthSystem.VsanQueryVcClusterHealthSummaryTask*.  This is used to get the health summary performed by the given task. If the task is still running, *VsanVcClusterHealthSystem.VsanQueryVcClusterHealthSummary* returns health check groups which are already completed. If the task is completed, *VsanVcClusterHealthSystem.VsanQueryVcClusterHealthSummary* returns full health summary from cache (Notes: fetchFromCache should be True). *VsanVcClusterHealthSystem.VsanQueryVcClusterHealthSummary* returns VsanFault if task ID is invalid or task state is &#39;error&#39;.  Refers instance of *Task*.  | [optional] 
**DiskNames** | **List&lt;string&gt;** | A list of disks to be validated for hardware compatibility.  If this field is set, the hardware compatibility check will only return the result of the disks in list. Both disk canonical name (e.g. &#39;mpx.vmhba0:C0:T0:L0&#39;) and UUID are supported. The field only takes effect with perspective &#39;vcsaInstallerForVsanEsa&#39;.  | [optional] 
**IncludeHealthRemediation** | **bool** | True to include vSAN health remediation and troubleshooting information in the data driven health test result.  It&#39;s false by default or when it&#39;s not set.  | [optional] 
**ExcludeChecks** | **List&lt;string&gt;** | A list of health checks to be excluded in this health query.  Each health check item in this list is a testId string. If this field is set, the health checks in this list will not be included in the health query result. This is mainly used to support skipping some health checks in vLCM upgrade precheck workflow.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

