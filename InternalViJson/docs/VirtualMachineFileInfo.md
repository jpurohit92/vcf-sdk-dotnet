# Vcenter.ViJson.OpenApi.Model.VirtualMachineFileInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VmPathName** | **string** | Path name to the configuration file for the virtual machine, e.g., the .vmx file.  This also implicitly defines the configuration directory.  | [optional] 
**SnapshotDirectory** | **string** | Path name of the directory that holds suspend and snapshot files belonging to the virtual machine.  Prior to vSphere 5.0, this directory also holds snapshot redo files. Starting with vSphere 5.0, the redo files will stay in the same directory as the snapshotted disk, thus this directory will no longer hold the snapshot redo files.  This path name defaults to the same directory as the configuration file.  ESX Server requires this to indicate a VMFS volume or NAS volume (for ESX Server 3). In case the configuration file is not stored on VMFS or NAS, this property must be set explicitly.  | [optional] 
**SuspendDirectory** | **string** | Some products allow the suspend directory to be different than the snapshot directory.  On products where this is not possible, setting of this property is ignored.  | [optional] 
**LogDirectory** | **string** | Directory to store the log files for the virtual machine.  If not specified, this defaults to the same directory as the configuration file,  | [optional] 
**FtMetadataDirectory** | **string** | Directory to store the fault tolerance meta data files for the virtual machine.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

