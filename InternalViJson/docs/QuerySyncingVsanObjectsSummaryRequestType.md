# Vcenter.ViJson.OpenApi.Model.QuerySyncingVsanObjectsSummaryRequestType
The parameters of *VsanObjectSystem.QuerySyncingVsanObjectsSummary*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | vSAN cluster.  ***Required privileges:*** System.Read  Refers instance of *ComputeResource*.  | 
**SyncingObjectFilter** | [**VsanSyncingObjectFilter**](VsanSyncingObjectFilter.md) | Filter spec for summary.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

