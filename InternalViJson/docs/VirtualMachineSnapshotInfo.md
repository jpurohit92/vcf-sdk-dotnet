# Vcenter.ViJson.OpenApi.Model.VirtualMachineSnapshotInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentSnapshot** | [**ManagedObjectReference**](ManagedObjectReference.md) | Current snapshot of the virtual machine  This property is set by calling *Snapshot.revert* or *VirtualMachine.createSnapshot*. This property will be empty when the working snapshot is at the root of the snapshot tree.  Refers instance of *VirtualMachineSnapshot*.  | [optional] 
**RootSnapshotList** | [**List&lt;VirtualMachineSnapshotTree&gt;**](VirtualMachineSnapshotTree.md) | Data for the entire set of snapshots for one virtual machine.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

