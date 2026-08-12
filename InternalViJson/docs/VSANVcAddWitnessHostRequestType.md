# Vcenter.ViJson.OpenApi.Model.VSANVcAddWitnessHostRequestType
The parameters of *VimClusterVsanVcStretchedClusterSystem.VSANVcAddWitnessHost*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target vSAN cluster to add/replace witness host;  ***Required privileges:*** Host.Inventory.AddHostToCluster  Refers instance of *ClusterComputeResource*.  | 
**WitnessHost** | [**ManagedObjectReference**](ManagedObjectReference.md) | The witness host to be added into vSAN cluster. This host must be connected and managed by the same vCenter server, and cannot be a part of target cluster;  Refers instance of *HostSystem*.  | 
**PreferredFd** | **string** | The name of preferred Fault Domain;  | 
**DiskMapping** | [**VsanHostDiskMapping**](VsanHostDiskMapping.md) | The diskMapping to be created on witness host. If disk claim is configured as auto-mode on witness host, this parameter is not required.  | [optional] 
**MetadataMode** | **bool** | True to indicate the host runs as metadata host instead of normal witness host. This is currently reserved by VMware internally to represent a different cluster type other than stretched cluster. Leave this unset for vSAN stretched cluster.  | [optional] 
**StoragePoolSpec** | [**VsanAddStoragePoolDiskSpec**](VsanAddStoragePoolDiskSpec.md) | The specification to add disks to vSAN storage pool. This parameter cannot be set together with diskMapping param.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

