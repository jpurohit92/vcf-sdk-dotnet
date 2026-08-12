# Vcenter.ViJson.OpenApi.Model.PointInTimeReplicaInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**PointInTimeReplicaId**](PointInTimeReplicaId.md) | Id of the PIT replica.  Note that this id is always used in combination with the *ReplicationGroupId*, hence must be unique to the *ReplicationGroupId*.  | 
**PitName** | **string** | Name of the PIT replica.  This may be a localized string in a language as chosen by the VASA provider.  | 
**TimeStamp** | **DateTime** | Time when the snapshot was taken.  Time stamps are maintained by the Replication provider, note that this carries time zone information as well.  | 
**Tags** | **List&lt;string&gt;** | VASA provider managed tags associated with the replica.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

