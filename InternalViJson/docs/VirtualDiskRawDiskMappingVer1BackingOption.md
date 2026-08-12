# Vcenter.ViJson.OpenApi.Model.VirtualDiskRawDiskMappingVer1BackingOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoDetectAvailable** | [**BoolOption**](BoolOption.md) | Flag to indicate whether the specific instance of this device can be auto-detected on the host instead of having to specify a particular physical device.  | 
**DescriptorFileNameExtensions** | [**ChoiceOption**](ChoiceOption.md) | Valid extensions for the filename of the optional raw disk mapping descriptor file.  This is present only for ESX Server 3.x and greater hosts.  | [optional] 
**CompatibilityMode** | [**ChoiceOption**](ChoiceOption.md) | The supported raw disk mapping compatibility modes.  See also *VirtualDiskCompatibilityMode_enum*.  | 
**DiskMode** | [**ChoiceOption**](ChoiceOption.md) | The disk mode.  Valid values are: - *persistent* - *independent_persistent* - *independent_nonpersistent*    See also *VirtualDiskMode_enum*.  | 
**Uuid** | **bool** | Flag to indicate whether this backing supports disk UUID property.  | 
**VirtualDiskFormat** | [**ChoiceOption**](ChoiceOption.md) | Virtual disk format.  See *DatastoreSectorFormat_enum* for the list of supported types.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

