# Vcenter.ViJson.OpenApi.Model.ReplicationVmInProgressFault

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reason** | **string** | The reason for the failure.  One of the above.  | 
**State** | **string** | The current *ReplicationVmState_enum* of the *VirtualMachine*  | [optional] 
**InstanceId** | **string** | The name of the instance currently being created.  | [optional] 
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine, for identification purposes.  Refers instance of *VirtualMachine*.  | 
**RequestedActivity** | **string** | The requested activity for VM replication  | 
**InProgressActivity** | **string** | The in-progress activity for VM replication  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

