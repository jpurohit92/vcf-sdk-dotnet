# Vcenter.ViJson.OpenApi.Model.VirtualMachineFileLayoutExSnapshotLayout

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to the snapshot.  Refers instance of *VirtualMachineSnapshot*.  | 
**DataKey** | **int** | Key to the snapshot data file in *VirtualMachineFileLayoutEx.file*.  | 
**MemoryKey** | **int** | Key to the snapshot memory file in *VirtualMachineFileLayoutEx.file*.  Powered off snapshots do not have a memory component and in some cases the memory component is combined with the data component. When a memory component does not exist, the value is initialized to -1.  | 
**Disk** | [**List&lt;VirtualMachineFileLayoutExDiskLayout&gt;**](VirtualMachineFileLayoutExDiskLayout.md) | Layout of each virtual disk of the virtual machine when the snapshot was taken.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

