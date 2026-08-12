# Vcenter.ViJson.OpenApi.Model.BatchAddHostsToClusterRequestType
The parameters of *Folder.BatchAddHostsToCluster_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | Specifies the cluster to which hosts need to be added.  Refers instance of *ClusterComputeResource*.  | 
**NewHosts** | [**List&lt;FolderNewHostSpec&gt;**](FolderNewHostSpec.md) | Specifies a list of new hosts to be added to the cluster. Hosts are first added as standalone hosts.  | [optional] 
**ExistingHosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Specifies a list of existing hosts to be added to the cluster. Hosts are first moved to the desired state before moving them to cluster.  Refers instances of *HostSystem*.  | [optional] 
**CompResSpec** | [**ComputeResourceConfigSpec**](ComputeResourceConfigSpec.md) | Specifies the configuration for the compute resource that will be created to contain all the hosts.  | [optional] 
**DesiredState** | **string** | Specifies desired state for hosts once added to the cluster. If not specified, hosts are added to the cluster in their current state. See *FolderDesiredHostState_enum* for valid values.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

