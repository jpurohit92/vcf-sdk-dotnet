# Vcenter.Automation.OpenApi.Model.VcenterVmGuestProcessesInfo
The Vcenter.Vm.Guest.Processes.Info schema describes the state of a guest process.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The process name.  This property was added in __vSphere API 7.0.2.0__. | 
**Owner** | **string** | The process owner.  This property was added in __vSphere API 7.0.2.0__. | 
**Command** | **string** | The full command line of the process.  This property was added in __vSphere API 7.0.2.0__. | 
**Started** | **DateTime** | The start time of the process.  This property was added in __vSphere API 7.0.2.0__. | 
**Finished** | **DateTime** | If the process was started using *POST /vcenter/vm/{vm}/guest/processes?action&#x3D;create* then the process completion time will be available if queried within 5 minutes after it completes.  This property was added in __vSphere API 7.0.2.0__.  Set if the process was started with *POST /vcenter/vm/{vm}/guest/processes?action&#x3D;create* and has recently exited. | [optional] 
**ExitCode** | **long** | If the process was started using *POST /vcenter/vm/{vm}/guest/processes?action&#x3D;create* then the process exit code will be available if queried within 5 minutes after it completes.  This property was added in __vSphere API 7.0.2.0__.  Set if the process was started with *POST /vcenter/vm/{vm}/guest/processes?action&#x3D;create* and has recently exited. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

