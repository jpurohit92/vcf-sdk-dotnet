# Vcenter.ViJson.OpenApi.Model.VimClusterVsanWitnessSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host that will act as a witness.  Refers instance of *HostSystem*.  | 
**PreferredFaultDomainName** | **string** | The preferred fault domain in the vSAN Stretched Cluster.  | 
**DiskMapping** | [**VsanHostDiskMapping**](VsanHostDiskMapping.md) | The disk mappings of the witness host.  This is needed if the vSAN cluster is in MANUAL claiming mode.  | [optional] 
**StoragePoolSpec** | [**VsanAddStoragePoolDiskSpec**](VsanAddStoragePoolDiskSpec.md) | The specification to add disks to vSAN storage pool.  This parameter cannot be set together with diskMapping param.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

