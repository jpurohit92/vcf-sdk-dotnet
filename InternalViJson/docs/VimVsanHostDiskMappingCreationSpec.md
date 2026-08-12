# Vcenter.ViJson.OpenApi.Model.VimVsanHostDiskMappingCreationSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Target host to create vSAN disk group.  Refers instance of *HostSystem*.  | 
**CacheDisks** | [**List&lt;HostScsiDisk&gt;**](HostScsiDisk.md) | Disk(s) to be used as cache tier of disk group.  If the specification is used to create new disk group, disk(s) set to this field must not be used by vSAN, and this field is required; if the specification is used to append disk(s) to existing disk group, this field is optional, and cannot accept more than one disk, and disk specified here should be the cache tier of existing disk group.  | [optional] 
**CapacityDisks** | [**List&lt;HostScsiDisk&gt;**](HostScsiDisk.md) | Disk(s) to be used as capacity tier of disk group.  All disk(s) specified to this field, must not be used by vSAN. This field can also be used in vSAN direct datastore provision, i.e. *VimVsanHostDiskMappingCreationSpec.creationType* set to \&quot;vsandirect\&quot;. It represents all the disk(s) used to create vSAN direct datastores. All disk(s) specified to this field must not be used by vSAN or any other datastores.  | [optional] 
**CreationType** | **string** | Disk group type to create.  See also *VimVsanHostDiskMappingCreationType_enum*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

