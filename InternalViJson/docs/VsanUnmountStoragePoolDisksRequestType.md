# Vcenter.ViJson.OpenApi.Model.VsanUnmountStoragePoolDisksRequestType
The parameters of *VimClusterVsanVcDiskManagementSystem.VsanUnmountStoragePoolDisks*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The vSAN cluster which owns the given storage pool disk(s).  Refers instance of *ClusterComputeResource*.  | 
**Spec** | [**VsanDeleteStoragePoolDiskSpec**](VsanDeleteStoragePoolDiskSpec.md) | The specification to unmount vSAN storage pool. Please reference to VimVsanHostDeleteStoragePoolDiskSpec.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

