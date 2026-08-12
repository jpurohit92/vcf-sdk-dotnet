# Vcenter.ViJson.OpenApi.Model.SyncReplicationGroupSuccessResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | [**ReplicationGroupId**](ReplicationGroupId.md) | Replication group Id.  | 
**Warning** | [**List&lt;MethodFault&gt;**](MethodFault.md) |  | [optional] 
**TimeStamp** | **DateTime** | Creation time of the PIT  | 
**PitId** | [**PointInTimeReplicaId**](PointInTimeReplicaId.md) | PIT id.  If the VASA provider does not support PIT, this can be left unset.  A PIT created as a result of the &lt;code&gt;syncReplicationGroup&lt;/code&gt; may or may not have the same retention policy as other PITs. A VASA provider can choose to delete such a PIT after a successful &lt;code&gt;testFailoverStop&lt;/code&gt;  | [optional] 
**PitName** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

