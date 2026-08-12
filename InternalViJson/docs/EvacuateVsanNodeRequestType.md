# Vcenter.ViJson.OpenApi.Model.EvacuateVsanNodeRequestType
The parameters of *HostVsanSystem.EvacuateVsanNode_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaintenanceSpec** | [**HostMaintenanceSpec**](HostMaintenanceSpec.md) | Specifies the data evacuation mode. See *HostMaintenanceSpec*. If unspecified, the default mode chosen will be *ensureObjectAccessibility*.  | 
**Timeout** | **int** | Time to wait for the task to complete in seconds. If the value is less than or equal to zero, there is no timeout. The operation fails with a Timedout exception if it timed out.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

