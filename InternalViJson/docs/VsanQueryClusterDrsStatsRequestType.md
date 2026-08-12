# Vcenter.ViJson.OpenApi.Model.VsanQueryClusterDrsStatsRequestType
The parameters of *VsanVcClusterConfigSystem.VsanQueryClusterDrsStats*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target vSAN cluster;  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | 
**Vms** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Specified VM list of which runtime stats should be reported. If omitted return stats of all vSAN VMs locate in specified vSAN cluster;  Refers instances of *VirtualMachine*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

