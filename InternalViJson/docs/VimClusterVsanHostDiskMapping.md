# Vcenter.ViJson.OpenApi.Model.VimClusterVsanHostDiskMapping

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host that the mappings are related.  Refers instance of *HostSystem*.  | 
**CacheDisks** | [**List&lt;HostScsiDisk&gt;**](HostScsiDisk.md) | List of disk that should be used for the cache tier.  | [optional] 
**CapacityDisks** | [**List&lt;HostScsiDisk&gt;**](HostScsiDisk.md) | List of disks that should be used for the capacity tier.  This field can also be used in vSAN direct datastore provision, i.e. *VimClusterVsanHostDiskMapping.type* set to \&quot;vsandirect\&quot;. It represents all the disk(s) used to create vSAN direct datastores. All disk(s) specified to this field must not be used by vSAN or any other datastores.  | [optional] 
**Type** | **string** | The type of the groups that should be created.  See also *VimClusterVsanDiskGroupCreationType_enum*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

