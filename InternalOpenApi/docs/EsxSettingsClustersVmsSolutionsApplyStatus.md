# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsSolutionsApplyStatus
The Esx.Settings.Clusters.Vms.Solutions.ApplyStatus schema contains properties that describe the status of an *POST /esx/settings/clusters/{cluster}/vms/solutions?action=apply* operation.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status of the operation.  Possible values:   - &#x60;SUCCESS&#x60;: The apply operation completed successfully.   - &#x60;ERROR&#x60;: The apply operation encountered an error.   For more information see: *Esx.Settings.Clusters.Vms.Solutions.ApplyStatus.Status*.  This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; if the operation is not completed. | [optional] 
**StartTime** | **DateTime** | The vLCM system time when the operation started.  This property was added in __vSphere API 9.0.0.0__. | 
**EndTime** | **DateTime** | The vLCM system time when the operation completed.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of status is one of *Esx.Settings.Clusters.Vms.Solutions.ApplyStatus.Status.SUCCESS* or *Esx.Settings.Clusters.Vms.Solutions.ApplyStatus.Status.ERROR*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

