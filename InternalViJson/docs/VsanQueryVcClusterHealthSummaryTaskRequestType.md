# Vcenter.ViJson.OpenApi.Model.VsanQueryVcClusterHealthSummaryTaskRequestType
The parameters of *VsanVcClusterHealthSystem.VsanQueryVcClusterHealthSummaryTask*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster  ***Required privileges:*** System.Read  Refers instance of *ClusterComputeResource*.  | 
**Hosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Include the individual host(s) into the health check, with other hosts specified with the cluster parameter  Refers instances of *HostSystem*.  | [optional] 
**IncludeDataProtectionHealth** | **bool** | This parameter is not used, and no data protection health will be collected.  | [optional] 
**IncludeOnlineHealth** | **bool** | True to trigger vSAN online health. The default is True.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

