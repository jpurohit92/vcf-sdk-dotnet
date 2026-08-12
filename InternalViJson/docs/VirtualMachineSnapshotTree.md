# Vcenter.ViJson.OpenApi.Model.VirtualMachineSnapshotTree

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Snapshot** | [**ManagedObjectReference**](ManagedObjectReference.md) | The managed object for this snapshot.  Refers instance of *VirtualMachineSnapshot*.  | 
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine for which the snapshot was taken.  Refers instance of *VirtualMachine*.  | 
**Name** | **string** | Name of the snapshot.  | 
**Description** | **string** | Description of the snapshot.  | 
**Id** | **int** | The unique identifier that distinguishes this snapshot from other snapshots of the virtual machine.  | 
**CreateTime** | **DateTime** | The date and time the snapshot was taken.  | 
**State** | **VirtualMachinePowerStateEnum** | The power state of the virtual machine when this snapshot was taken.  | 
**Quiesced** | **bool** | Flag to indicate whether or not the snapshot was created with the \&quot;quiesce\&quot; option, ensuring a consistent state of the file system.  | 
**BackupManifest** | **string** | The relative path from the snapshotDirectory pointing to the backup manifest.  Available for certain quiesced snapshots only.  | [optional] 
**ChildSnapshotList** | [**List&lt;VirtualMachineSnapshotTree&gt;**](VirtualMachineSnapshotTree.md) | The snapshot data for all snapshots for which this snapshot is the parent.  | [optional] 
**ReplaySupported** | **bool** | Deprecated as of vSphere API 6.0.  Flag to indicate whether this snapshot is associated with a recording session on the virtual machine that can be replayed.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

