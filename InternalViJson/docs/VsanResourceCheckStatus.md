# Vcenter.ViJson.OpenApi.Model.VsanResourceCheckStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The overall status of the resource check that is queried.  Please see *VsanResourceCheckStatusType_enum* for possible statuses.  See also *VsanResourceCheckStatusType_enum*.  | 
**Result** | [**VsanResourceCheckResult**](VsanResourceCheckResult.md) | The result of the resource check that is queried.  This field will be populated only if a resource check has completed successfully and recently, i.e., only when *VsanResourceCheckStatus.status* is \&quot;completed\&quot;. For \&quot;EnterMaintenanceMode\&quot; operation, this will be the aggregated result for both regular vSAN and vSphere data persistence platform. For detailed result of each component, please look into *VsanResourceCheckStatus.componentResults*. For other resource check types, this will be the result for regular vSAN as usual. The same vSAN component result will also be in *VsanResourceCheckStatus.componentResults*.  | [optional] 
**Task** | [**VsanResourceCheckTaskDetails**](VsanResourceCheckTaskDetails.md) | The details of the resource check task that was generated and returned by *VsanResourceCheckSystem.VsanPerformResourceCheck*.  It will be set only when *VsanResourceCheckStatus.status* is \&quot;resourceCheckRunning\&quot;. The derived class *VsanDiskDataEvacuationResourceCheckTaskDetails* will be used if the resource check task is for disk/disk-group data evacuation.  | [optional] 
**ParentTask** | [**VsanResourceCheckTaskDetails**](VsanResourceCheckTaskDetails.md) | The details of the parent task passed in by *VsanResourceCheckSpec.parent*.  It will be set only when the resource check is launched from a parent task and the state of the parent task is \&quot;running\&quot;.  | [optional] 
**ComponentResults** | [**List&lt;VsanResourceCheckComponentResult&gt;**](VsanResourceCheckComponentResult.md) | The detailed resource check result for different components.  The data persistence component resource check result is only available when the operation is \&quot;EnterMaintenanceMode\&quot; at the moment. For other resource check types, only the regular vSAN result will be available.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

