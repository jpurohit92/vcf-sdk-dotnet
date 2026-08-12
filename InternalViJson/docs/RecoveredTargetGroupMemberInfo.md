# Vcenter.ViJson.OpenApi.Model.RecoveredTargetGroupMemberInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReplicaId** | [**ReplicaId**](ReplicaId.md) | Identifier of the replica device.  | 
**SourceId** | [**DeviceId**](DeviceId.md) | Source device, since the device id can be the same in all the domains, this needs to supplemented with the domain id to identify the device.  | 
**TargetDatastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | Datastore of the target device.  This may be used by CAM/SRM to notify the administrators to setup access paths for the hosts to access the recovered devices.  Refers instance of *Datastore*.  | 
**RecoveredDeviceId** | [**DeviceId**](DeviceId.md) | Identifier of the target device after test or failover.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

