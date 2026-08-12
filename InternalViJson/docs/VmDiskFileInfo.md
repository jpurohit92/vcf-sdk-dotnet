# Vcenter.ViJson.OpenApi.Model.VmDiskFileInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | The path relative to the folder path in the search results.  | 
**FriendlyName** | **string** | User friendly name.  | [optional] 
**FileSize** | **long** | The size of the file in bytes.  | [optional] 
**Modification** | **DateTime** | The last date and time the file was modified.  | [optional] 
**Owner** | **string** | The user name of the owner of the file.  | [optional] 
**DiskType** | **string** | Disk type of the virtual disk.  The specified disk type is one of the backing information types for a virtual disk.  See also *VirtualDisk*.  | [optional] 
**CapacityKb** | **long** | The capacity of a virtual disk from the point of view of a virtual machine.  | [optional] 
**HardwareVersion** | **int** | The hardware version of the virtual disk file.  | [optional] 
**ControllerType** | **string** | Deprecated as of vSphere API 5.0, this property is no longer relevant and should not be used. With the current state of emulation, we don&#39;t care about the adapter type a disk is connected to, as disks may be shuffled around. For example, a disk may be unplugged from a buslogic controller and plugged into an lsilogic controller.  The controller type suitable for this virtual disk.  | [optional] 
**DiskExtents** | **List&lt;string&gt;** | The extents of this virtual disk specified in absolute DS paths  | [optional] 
**Thin** | **bool** | Indicates if the disk is thin-provisioned  | [optional] 
**Encryption** | [**VmDiskFileEncryptionInfo**](VmDiskFileEncryptionInfo.md) | The encryption information of the virtual disk.  If encryption was selected in VmDiskFileQueryFlags then this field is always set. Inspect the VmDiskEncryptionInfo to determine if the virtual disk is encrypted.  | [optional] 
**SectorFormat** | **string** | Sector format of this virtual disk.  For the list of supported values, see *DatastoreSectorFormat_enum*.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

