# Vcenter.ViJson.OpenApi.Model.RepairTimerInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxTimeToRepair** | **int** | The longest time remaining for triggering repair work for objects with absent components in seconds.  | 
**MinTimeToRepair** | **int** | The shortest time remaining for triggering repair work for objects with absent components in seconds.  | 
**ObjectCount** | **int** | The number of the objects with absent component that need repair.  | 
**ObjectCountWithRepairTimer** | **int** | The number of the objects which need repair and it&#39;s time since incompliance is still less than *VsanExtendedConfig.objectRepairTimer*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

