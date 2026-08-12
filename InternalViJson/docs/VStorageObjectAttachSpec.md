# Vcenter.ViJson.OpenApi.Model.VStorageObjectAttachSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VolumeId** | [**ID**](ID.md) | The ID of the virtual disk to be operated.  See *ID*  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | datastore where the volume is located.  Refers instance of *Datastore*.  | 
**DiskMode** | **string** | The disk persistence mode.  Supported modes are listed in *VirtualDiskMode_enum* When unset, default mode is *vim.vm.device.VirtualDiskOption#persistent* (that also means dependent persistent to CNS) see *VirtualDiskMode_enum*  | [optional] 
**Sharing** | **string** | The sharing mode of the virtual disk.  Supported modes are listed in *VirtualDiskSharing_enum* When unset, default value is *sharingNone* See *VirtualDiskSharing_enum*  | [optional] 
**ControllerKey** | **int** | Key of the controller the disk will connect to.  It can be unset if there is only one controller (SCSI/SATA/NVMe) with the available slot in the virtual machine. If there are multiple SCSI/SATA/NVMe controllers available, user must specify the controller; if there is no available controllers, a *MissingController* fault will be thrown.  | [optional] 
**UnitNumber** | **int** | The unit number of the disk to be attached on its controller.  If unset, the next free slot on the specified controller or on the only available controller will be assigned to the attached disk.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

