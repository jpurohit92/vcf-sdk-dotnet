# Vcenter.ViJson.OpenApi.Model.VsanVcsaDeploymentProgress

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Phase** | **string** | The overall deploy is divided into multiple phases, e.g.  validation, vsanbootstrap, vcsadeploy, vcconfig, etc.  See also *VimVsanVsanVcsaDeploymentPhase_enum*.  | 
**ProgressPct** | **long** | Overall progress of the job in percent.  | 
**Message** | **string** | Status message about current operation of the background job.  | 
**Success** | **bool** | Set if the job completed successfully.  If it is not set, it is either still running or failed. See error property.  | 
**Error** | [**MethodFault**](MethodFault.md) | Set if the job aborted with failure.  If it is not set, it is either still running or succeeded. See success property.  | [optional] 
**UpdateCounter** | **long** | Any time the progress changes this counter is incremented.  This way a client can determine if the progress has changed when retrieving the progress at different points in time. Never negative.  | 
**TaskId** | **string** | Unique identifier of the task this progress report is for.  | [optional] 
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual Machine that was created.  Refers instance of *VirtualMachine*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

