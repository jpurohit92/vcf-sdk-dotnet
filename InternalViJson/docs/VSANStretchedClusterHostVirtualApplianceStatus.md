# Vcenter.ViJson.OpenApi.Model.VSANStretchedClusterHostVirtualApplianceStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VcCluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | Cluster compute resource of the vSAN cluster, which is a stretched cluster.  This attribute is planning to be deprecated, please use vcClusters instead of this vcCluster.  Refers instance of *ClusterComputeResource*.  | [optional] 
**IsVirtualApp** | **bool** | Host is a virtual appliance or not  | [optional] 
**VcClusters** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Cluster compute resources of the vSAN clusters that using this host virtual appliance as witness host, which is a list of stretched clusters.  Refers instances of *ClusterComputeResource*.  | [optional] 
**IsVirtualAppValid** | **bool** | Witness appliance has been updated  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

