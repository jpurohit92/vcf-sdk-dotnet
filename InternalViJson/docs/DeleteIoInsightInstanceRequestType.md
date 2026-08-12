# Vcenter.ViJson.OpenApi.Model.DeleteIoInsightInstanceRequestType
The parameters of *VsanIoInsightManager.DeleteIoInsightInstance*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunName** | **string** | Run name of the ioinsight instance.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster where the ioinsight instance belongs to. This parameter is ignored while the API is called against host.  ***Required privileges:*** Global.Diagnostics  Refers instance of *ClusterComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

