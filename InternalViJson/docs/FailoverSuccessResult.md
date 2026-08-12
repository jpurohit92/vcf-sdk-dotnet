# Vcenter.ViJson.OpenApi.Model.FailoverSuccessResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | [**ReplicationGroupId**](ReplicationGroupId.md) | Replication group Id.  | 
**Warning** | [**List&lt;MethodFault&gt;**](MethodFault.md) |  | [optional] 
**NewState** | **string** | Some replicators may automatically reverse replication on failover.  Such replicators must move the replication status to *SOURCE* In other cases, it can remain as *FAILEDOVER*.  | 
**PitId** | [**PointInTimeReplicaId**](PointInTimeReplicaId.md) | Id of the Point in Time snapshot used during failover.  If not present, latest PIT was used.  | [optional] 
**PitIdBeforeFailover** | [**PointInTimeReplicaId**](PointInTimeReplicaId.md) | Optional id of the Point in Time snapshot that was automatically created before failing over.  This is recommended so users can revert back to this snapshot to avoid data loss. This can be removed after the reverse replication call succeeds.  | [optional] 
**RecoveredDeviceInfo** | [**List&lt;RecoveredDevice&gt;**](RecoveredDevice.md) | Recovered Devices.  This is optional because in some corner cases the replication groups on the target site may not have any virtual volumes.  | [optional] 
**TimeStamp** | **DateTime** | Time stamp of recovery.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

