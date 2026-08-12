# Vcenter.ViJson.OpenApi.Model.VsanIODiagnosticsInstance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The instance name.  | 
**State** | **string** | The state of the instance, can be \&quot;VsanIODiagnosticsInstanceRunning\&quot; or \&quot;VsanIODiagnosticsInstanceCompleted\&quot;.  See also *VsanIODiagnosticsInstanceState_enum*.  | 
**Events** | [**List&lt;VsanIODiagnosticsInstanceEvent&gt;**](VsanIODiagnosticsInstanceEvent.md) | The event which makes the instance stopped, if the event is unset, it means the IO diagnostic operation completed without any events.  | [optional] 
**Targets** | [**List&lt;VsanIODiagnosticsTarget&gt;**](VsanIODiagnosticsTarget.md) | The targets that the IO diagnostics run against.  | [optional] 
**StartTime** | **DateTime** | The start time of the diagnostics.  | 
**EndTime** | **DateTime** | The end time of the diagnostics.  | 
**RecurrenceName** | **string** | The name of the recurrence if the instance is triggered by a recurrence.  ***Since:*** 8.0.0.4  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

