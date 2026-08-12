# Vcenter.ViJson.OpenApi.Model.VsanGetReleaseRecommendationRequestType
The parameters of *VsanVcClusterHealthSystem.VsanGetReleaseRecommendation*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target vSAN cluster  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | 
**Minor** | **List&lt;string&gt;** | A list of minor update releases. E.g., \\[&#39;ESXi 6.7 U2&#39;\\]  | 
**Major** | **List&lt;string&gt;** | A list of major update releases. E.g., \\[&#39;ESXi 6.8&#39;, &#39;ESXi 7.0&#39;\\]  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

