# Vcenter.ViJson.OpenApi.Model.VsanUnmountDiskMappingExRequestType
The parameters of *VsanSystemEx.VsanUnmountDiskMappingEx*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mappings** | [**List&lt;VsanHostDiskMapping&gt;**](VsanHostDiskMapping.md) | List of diskgroups to be unmounted.  | 
**MaintenanceSpec** | [**HostMaintenanceSpec**](HostMaintenanceSpec.md) | Any additional actions to move data out of the diskgroup before unmounting it. See *HostMaintenanceSpec*. If unspecified, there is no action taken to move data from the diskgroup.  | [optional] 
**Timeout** | **int** | Time to wait for the task to complete in seconds. If the value is less than or equal to zero, there is no timeout. The operation fails with a Timedout exception if it timed out.  | [optional] 
**EvacReason** | **string** | The reason to evacuate diskgroup. Allowed values can be found in *VsanDiskEvacReason_enum*  ***Since:*** 8.0.0.4  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

