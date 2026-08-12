# Vcenter.ViJson.OpenApi.Model.VirtualDiskSparseVer1BackingOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileNameExtensions** | [**ChoiceOption**](ChoiceOption.md) | Valid filename extension for the filename.  If no extensions are present, any file extension is acceptable.  | [optional] 
**DiskModes** | [**ChoiceOption**](ChoiceOption.md) | The disk mode.  Valid disk modes are: - *persistent* - *nonpersistent* - *undoable* - *independent_persistent* - *independent_nonpersistent* - *append*    See also *VirtualDiskMode_enum*.  | 
**Split** | [**BoolOption**](BoolOption.md) | Flag to indicate whether or not the host supports allowing the client to select whether or not a sparse disk should be split.  | 
**WriteThrough** | [**BoolOption**](BoolOption.md) | Flag to indicate whether or not the host supports allowing the client to select \&quot;writethrough\&quot; as a mode for virtual disks.  Typically, this is available only for VMware Server Linux hosts.  | 
**Growable** | **bool** | Flag to indicate whether this backing can have its size changed.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

