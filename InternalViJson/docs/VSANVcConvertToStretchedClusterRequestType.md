# Vcenter.ViJson.OpenApi.Model.VSANVcConvertToStretchedClusterRequestType
The parameters of *VimClusterVsanVcStretchedClusterSystem.VSANVcConvertToStretchedCluster*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster to be converted; It is expected to enable vSAN, but not a vSAN stretched cluster;  ***Required privileges:*** Host.Inventory.EditCluster  Refers instance of *ClusterComputeResource*.  | 
**FaultDomainConfig** | [**VimClusterVSANStretchedClusterFaultDomainConfig**](VimClusterVSANStretchedClusterFaultDomainConfig.md) | The mapping between Fault Domain and vSAN hosts reside in target cluster, to decide how to configure vSAN cluster into two sites;  | 
**WitnessHost** | [**ManagedObjectReference**](ManagedObjectReference.md) | The witness host to be added into vSAN cluster. This host must be connected and managed by the same vCenter server, and cannot be a part of target cluster;  Refers instance of *HostSystem*.  | 
**PreferredFd** | **string** | The name of preferred Fault Domain;  | 
**DiskMapping** | [**VsanHostDiskMapping**](VsanHostDiskMapping.md) | The diskMapping to be created on witness host. If disk claim is configured as auto-mode on witness host, this parameter is not required.  | [optional] 
**StoragePoolSpec** | [**VsanAddStoragePoolDiskSpec**](VsanAddStoragePoolDiskSpec.md) | The specification to add disks to vSAN storage pool. This parameter cannot be set together with diskMapping param.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

