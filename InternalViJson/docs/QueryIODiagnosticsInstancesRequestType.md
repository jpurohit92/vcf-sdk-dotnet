# Vcenter.ViJson.OpenApi.Model.QueryIODiagnosticsInstancesRequestType
The parameters of *VsanDiagnosticsSystem.QueryIODiagnosticsInstances*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuerySpec** | [**VsanIODiagnosticsInstanceQuerySpec**](VsanIODiagnosticsInstanceQuerySpec.md) | The spec for instance query.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster where the diagnostics is performed, ignored when calling against ESXi hosts.  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

