# Vcenter.ViJson.OpenApi.Model.CnsVolumeAttachDetachSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VolumeId** | [**CnsVolumeId**](CnsVolumeId.md) | Unique identifier and datastore information for the volume.  | 
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | VirtualMachine to which this volume needs to be attached to.  Refers instance of *VirtualMachine*.  | 
**DiskMode** | **string** | The disk persistence mode.  Valid modes are vim.vm.device.VirtualDiskOption.DiskMode#persistent vim.vm.device.VirtualDiskOption.DiskMode#independent\\_persistent vim.vm.device.VirtualDiskOption.DiskMode#independent\\_nonpersistent vim.vm.device.VirtualDiskOption.DiskMode#nonpersistent vim.vm.device.VirtualDiskOption.DiskMode#undoable vim.vm.device.VirtualDiskOption.DiskMode#append When unset, default mode is persistent(that also means dependant persistent to CNS) see *VirtualDiskMode_enum*  | [optional] 
**Sharing** | **string** | The sharing mode of the virtual disk.  Valid values are vim.vm.device.VirtualDisk.Sharing#sharingNone vim.vm.device.VirtualDisk.Sharing#sharingMultiWriter When unset, default value is sharingNone See *VirtualDiskSharing_enum*  | [optional] 
**ControllerKey** | **int** | Key of the controller the disk will connect to.  It can be unset if there is only one controller (SCSI/SATA/NVME) with the available slot in the virtual machine. If there are multiple SCSI/SATA/NVME controllers available, user must specify the controller; if there is no available controllers, a *MissingController* fault will be thrown.  | [optional] 
**UnitNumber** | **int** | The unit number of the disk to be attached on its controller.  If unset, the next free slot on the specified controller or on the only available controller will be assigned to the attached disk.  | [optional] 
**BackingTypeName** | **string** | Specifies the file backing type for the volume.  Valid values are defined in *CnsVolumeBackingType_enum*  For dynamically provisioned volumes: - If not provided, defaults to *VirtualDiskFlatVer2BackingInfo* - If provided, the specified backing type will be used.    For statically provisioned volumes: - This field is required. If not provided, a *CnsFault* will be thrown.  | [optional] 
**VolumeEncrypted** | **bool** | Indicates whether the volume is encrypted.  When set to true, the volume is encrypted and vpxd API *VirtualMachine.AttachVStorageObject_Task* will be called for cryptographic key handling during batch attach operations. When set to false, the volume is not encrypted and vpxd API *VirtualMachine.AttachVStorageObject_Task* call will be skipped. When unset, regardless of the volume encryption status, vpxd API *VirtualMachine.AttachVStorageObject_Task* will be called to determine the volume encryption status and perform cryptographic key handling if the volume is encrypted. Note: *VirtualMachine.AttachVStorageObject_Task* call might impact performance.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

