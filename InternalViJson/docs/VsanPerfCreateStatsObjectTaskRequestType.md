# Vcenter.ViJson.OpenApi.Model.VsanPerfCreateStatsObjectTaskRequestType
The parameters of *VsanPerformanceManager.VsanPerfCreateStatsObjectTask*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | vSAN cluster. Ignored if called against host.  ***Required privileges:*** Host.Inventory.EditCluster  Refers instance of *ComputeResource*.  | [optional] 
**Profile** | [**VirtualMachineProfileSpec**](VirtualMachineProfileSpec.md) | Profile to be used for the stats object, see above  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

