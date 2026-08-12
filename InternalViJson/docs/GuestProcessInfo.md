# Vcenter.ViJson.OpenApi.Model.GuestProcessInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The process name  | 
**Pid** | **long** | The process ID  | 
**Owner** | **string** | The process owner  | 
**CmdLine** | **string** | The full command line  | 
**StartTime** | **DateTime** | The start time of the process  | 
**EndTime** | **DateTime** | If the process was started using *GuestProcessManager.StartProgramInGuest* then the process completion time will be available if queried within 5 minutes after it completes.  | [optional] 
**ExitCode** | **int** | If the process was started using *GuestProcessManager.StartProgramInGuest* then the process exit code will be available if queried within 5 minutes after it completes.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

