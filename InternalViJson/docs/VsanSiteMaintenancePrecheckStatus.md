# Vcenter.ViJson.OpenApi.Model.VsanSiteMaintenancePrecheckStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **DateTime** | The timestamp indicating when the precheck was completed.  | 
**Status** | **string** | The overall status of the site maintenance precheck that was queried.  Please see *VsanResourceCheckStatusType_enum* for possible statuses.  See also *VsanResourceCheckStatusType_enum*.  | 
**TaskDetails** | [**VsanSiteMaintenanceCheckTaskDetails**](VsanSiteMaintenanceCheckTaskDetails.md) | The details of the precheck task that was generated and returned by PerformSiteMaintenancePrecheck  | [optional] 
**ResourceCheckResult** | [**VsanSiteMaintenanceResourceCheckResult**](VsanSiteMaintenanceResourceCheckResult.md) | The predicted resource impact details assuming the queried operation is performed.  This field will be populated only if a resource check for the queried precheck has completed successfully and recently.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

