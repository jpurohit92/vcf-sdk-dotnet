# Vcenter.ViJson.OpenApi.Model.CreateSnapshotRequestType
The parameters of *VirtualMachine.CreateSnapshot_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name for this snapshot. The name need not be unique for this virtual machine.  | 
**Description** | **string** | A description for this snapshot. If omitted, a default description may be provided.  | [optional] 
**Memory** | **bool** | If TRUE, a dump of the internal state of the virtual machine (basically a memory dump) is included in the snapshot. Memory snapshots consume time and resources, and thus take longer to create. When set to FALSE, the power state of the snapshot is set to powered off.  *capabilities* indicates whether or not this virtual machine supports this operation. For a virtual machine in suspended state we always include memory unless *VirtualMachineCapability.diskOnlySnapshotOnSuspendedVMSupported* is true.  | 
**Quiesce** | **bool** | If TRUE and the virtual machine is powered on when the snapshot is taken, VMware Tools is used to quiesce the file system in the virtual machine. This assures that a disk snapshot represents a consistent state of the guest file systems. If the virtual machine is powered off or VMware Tools are not available, the quiesce flag is ignored.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

