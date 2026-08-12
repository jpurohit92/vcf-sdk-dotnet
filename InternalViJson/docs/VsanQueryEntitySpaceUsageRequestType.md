# Vcenter.ViJson.OpenApi.Model.VsanQueryEntitySpaceUsageRequestType
The parameters of *VsanSpaceReportSystem.VsanQueryEntitySpaceUsage*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The vSAN cluster  ***Required privileges:*** System.Read  Refers instance of *ComputeResource*.  | 
**QuerySpec** | [**VsanSpaceQuerySpec**](VsanSpaceQuerySpec.md) | The vSAN space usage query spec to specify the entity types like virtual machine and the entity UUIDs like the managed object ID for virtual machines.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

