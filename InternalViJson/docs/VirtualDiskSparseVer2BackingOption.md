# Vcenter.ViJson.OpenApi.Model.VirtualDiskSparseVer2BackingOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileNameExtensions** | [**ChoiceOption**](ChoiceOption.md) | Valid filename extension for the filename.  If no extensions are present, any file extension is acceptable.  | [optional] 
**DiskMode** | [**ChoiceOption**](ChoiceOption.md) | The disk mode.  Valid disk modes are: - *persistent* - *nonpersistent* - *undoable* - *independent_persistent* - *independent_nonpersistent* - *append*    See also *VirtualDiskMode_enum*.  | 
**Split** | [**BoolOption**](BoolOption.md) | Flag to indicate whether or not the host supports allowing the client to select whether or not a sparse disk should be split.  | 
**WriteThrough** | [**BoolOption**](BoolOption.md) | Flag to indicate whether or not the host supports allowing the client to select \&quot;writethrough\&quot; as a mode for virtual disks.  Typically, this is available only for VMware Server Linux hosts.  | 
**Growable** | **bool** | Indicates whether or not this disk backing can be extended to larger sizes through a reconfigure operation.  If set to true, reconfiguring this virtual disk with a *VirtualDisk.capacityInKB* value greater than its current value will grow the disk to the newly specified size.  | 
**HotGrowable** | **bool** | Indicates whether or not this disk backing can be extended to larger sizes through a reconfigure operation while the virtual machine is powered on.  If set to true, reconfiguring this virtual disk with a *VirtualDisk.capacityInKB* value greater than its current value will grow the disk to the newly specified size while the virtual machine is powered on.  | 
**Uuid** | **bool** | Flag to indicate whether this backing supports disk UUID property.  | 
**VirtualDiskFormat** | [**ChoiceOption**](ChoiceOption.md) | Virtual disk format.  See *DatastoreSectorFormat_enum* for the list of supported types.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

