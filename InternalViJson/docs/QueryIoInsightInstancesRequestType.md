# Vcenter.ViJson.OpenApi.Model.QueryIoInsightInstancesRequestType
The parameters of *VsanIoInsightManager.QueryIoInsightInstances*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuerySpec** | [**VsanIoInsightInstanceQuerySpec**](VsanIoInsightInstanceQuerySpec.md) | Describe specifications for the query operation.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster where the ioinsight instances belong to. This parameter is ignored while the API is called against host.  ***Required privileges:*** Global.Diagnostics  Refers instance of *ClusterComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

