# Vcenter.ViJson.OpenApi.Model.VirtualMachineFileLayout

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigFile** | **List&lt;string&gt;** | A list of files that makes up the configuration of the virtual machine (excluding the .vmx file, since that file is represented in the FileInfo).  These are relative paths from the configuration directory. A slash is always used as a separator. This list will typically include the NVRAM file, but could also include other meta-data files.  | [optional] 
**LogFile** | **List&lt;string&gt;** | A list of files stored in the virtual machine&#39;s log directory.  These are relative paths from the logDirectory. A slash is always used as a separator.  | [optional] 
**Disk** | [**List&lt;VirtualMachineFileLayoutDiskLayout&gt;**](VirtualMachineFileLayoutDiskLayout.md) | Files making up each virtual disk.  | [optional] 
**Snapshot** | [**List&lt;VirtualMachineFileLayoutSnapshotLayout&gt;**](VirtualMachineFileLayoutSnapshotLayout.md) | Files of each snapshot.  | [optional] 
**SwapFile** | **string** | The swapfile specific to this virtual machine, if any.  This is a complete datastore path, not a relative path.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

