# Vcenter.ViJson.OpenApi.Model.VsanIOTripAnalyzerRecurrence

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The unique name for this recurrence setting.  If not given, it will generate the name automatically.  | [optional] 
**Targets** | [**List&lt;VsanIODiagnosticsTarget&gt;**](VsanIODiagnosticsTarget.md) | The target entity list to run the IO trip analyzer diagnosis.  Currently it supports only one entity to be given.  | 
**StartTime** | **DateTime** | The start time for the IO trip analyzer recurrence.  | 
**EndTime** | **DateTime** | The end time for the IO trip analyzer recurrence.  If not set, the recurrence will not end.  | [optional] 
**Duration** | **long** | The diagnostic duration for each IO trip analyzer occurence.  The unit is second.  | 
**Interval** | **long** | The time interval between two IO trip analyzer tasks.  If the value is set to 0, it means it is one-time IO trip analyzer scheduling, no recurrence needed. Unit is second.  | 
**Status** | **string** | The recurrence status.     If the status is set as enabled, the scheduler with this recurrence setting is up and running. Diagnostic tasks will be triggered based on the setting. If the status is set as disabled, the scheduler with this recurrence setting is not runninig. No diagnostic task will be triggered.  See also *VsanIOTripAnalyzerRecurrenceStatus_enum*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

