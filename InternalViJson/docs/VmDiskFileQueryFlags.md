# Vcenter.ViJson.OpenApi.Model.VmDiskFileQueryFlags

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiskType** | **bool** | The flag to indicate whether the type of the physical disk backing the virtual disk is returned.  | 
**CapacityKb** | **bool** | The flag to indicate whether the capacity of the virtual disk from the point of view of a virtual machine is returned.  | 
**HardwareVersion** | **bool** | The flag to indicate whether the hardware version of the virtual disk file is returned.  | 
**ControllerType** | **bool** | Deprecated as of vSphere API 5.0, this property is no longer relevant and should not be used. With the current state of emulation, we don&#39;t care about the adapter type a disk is connected to, as disks may be shuffled around. For example, a disk may be unplugged from a buslogic controller and plugged into an lsilogic controller.  The flag to indicate whether or not the controller type of the virtual disk file is returned.  | [optional] 
**DiskExtents** | **bool** | The flag to indicate whether or not the disk extents of the virtual disk are returned.  | [optional] 
**Thin** | **bool** | The flag to indicate whether the thin-ness of the disk is returned.  | [optional] 
**Encryption** | **bool** | The flag to indicate whether the encryption information of the virtual disk is returned.  | [optional] 
**SectorFormat** | **bool** | The flag to indicate whether or not the sector format of the virtual disk is returned.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

