# Vcenter.ViJson.OpenApi.Model.RecoveredDevice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TargetDeviceId** | [**ReplicaId**](ReplicaId.md) | Identifier of the device which was the target of replication before failover.  | [optional] 
**RecoveredDeviceId** | [**DeviceId**](DeviceId.md) | Identifier of the target device after test or failover.  | [optional] 
**SourceDeviceId** | [**DeviceId**](DeviceId.md) | Identifier of the source of the replication data before the failover stopped the replication.  | 
**Info** | **List&lt;string&gt;** | Informational messages.  | [optional] 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | Datastore for the newly surfaced device.  Refers instance of *Datastore*.  | 
**RecoveredDiskInfo** | [**List&lt;RecoveredDiskInfo&gt;**](RecoveredDiskInfo.md) | Only to be filled in if the *RecoveredDevice.recoveredDeviceId* is *VirtualMachineId*.  | [optional] 
**Error** | [**MethodFault**](MethodFault.md) | Virtual Volume specific recovery error.  This should be rare.  | [optional] 
**Warnings** | [**List&lt;MethodFault&gt;**](MethodFault.md) | Warnings.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

