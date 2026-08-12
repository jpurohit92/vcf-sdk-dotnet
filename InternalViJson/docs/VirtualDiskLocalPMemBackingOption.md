# Vcenter.ViJson.OpenApi.Model.VirtualDiskLocalPMemBackingOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileNameExtensions** | [**ChoiceOption**](ChoiceOption.md) | Valid filename extension for the filename.  If no extensions are present, any file extension is acceptable.  | [optional] 
**DiskMode** | [**ChoiceOption**](ChoiceOption.md) | The disk mode.  See also *VirtualDiskMode_enum*.  | 
**Growable** | **bool** | Indicates whether or not this disk backing can be extended to larger sizes through a reconfigure operation.  If set to true, reconfiguring this virtual disk with a *VirtualDisk.capacityInKB* value greater than its current value will grow the disk to the newly specified size.  | 
**HotGrowable** | **bool** | Indicates whether or not this disk backing can be extended to larger sizes through a reconfigure operation while the virtual machine is powered on.  If set to true, reconfiguring this virtual disk with a *VirtualDisk.capacityInKB* value greater than its current value will grow the disk to the newly specified size while the virtual machine is powered on.  | 
**Uuid** | **bool** | Flag to indicate whether this backing supports disk UUID property.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

