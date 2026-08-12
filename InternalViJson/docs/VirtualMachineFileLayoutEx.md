# Vcenter.ViJson.OpenApi.Model.VirtualMachineFileLayoutEx

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**File** | [**List&lt;VirtualMachineFileLayoutExFileInfo&gt;**](VirtualMachineFileLayoutExFileInfo.md) | Information about all the files that constitute the virtual machine including configuration files, disks, swap file, suspend file, log files, core files, memory file etc.  *VirtualMachineFileLayoutExFileType_enum* lists the different file-types that make a virtual machine.  | [optional] 
**Disk** | [**List&lt;VirtualMachineFileLayoutExDiskLayout&gt;**](VirtualMachineFileLayoutExDiskLayout.md) | Layout of each virtual disk attached to the virtual machine.  For a virtual machine with snapshots, this property gives only those disks that are attached to it at the current point of running.  | [optional] 
**Snapshot** | [**List&lt;VirtualMachineFileLayoutExSnapshotLayout&gt;**](VirtualMachineFileLayoutExSnapshotLayout.md) | Layout of each snapshot of the virtual machine.  | [optional] 
**Timestamp** | **DateTime** | Time when values in this structure were last updated.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

