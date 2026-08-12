# Vcenter.ViJson.OpenApi.Model.VirtualDiskRawDiskVer2BackingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceName** | **string** | The name of the device on the host system.  | 
**UseAutoDetect** | **bool** | Indicates whether the device should be auto detected instead of directly specified.  If this value is set to TRUE, deviceName is ignored.  | [optional] 
**DescriptorFileName** | **string** | The name of the raw disk descriptor file.  | 
**Uuid** | **string** | Disk UUID for the virtual disk, if available.  | [optional] 
**ChangeId** | **string** | The change ID of the virtual disk for the corresponding snapshot or virtual machine.  This can be used to track incremental changes to a virtual disk. See *VirtualMachine.QueryChangedDiskAreas*.  | [optional] 
**Sharing** | **string** | The sharing mode of the virtual disk.  See *VirtualDiskSharing_enum*. The default value is no sharing.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

