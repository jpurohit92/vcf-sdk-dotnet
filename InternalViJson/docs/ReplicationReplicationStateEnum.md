# Vcenter.ViJson.OpenApi.Model.ReplicationReplicationStateEnum
State of the replication group at the site of the query.  A replication group may be in different states at the source site and each of the target sites. Note that this state does not capture the health of the replication link. If necessary, that can be an additional attribute.  Possible values: - `SOURCE`: Replication Source - `TARGET`: Replication target - `FAILEDOVER`: The group failed over at this site of the query.      It has not yet been made   as a source of replication. - `INTEST`: The group is InTest.      The testFailover devices list will be available from   the *TargetGroupMemberInfo* - `REMOTE_FAILEDOVER`: Remote group was failed over, and this site is neither the source nor the   target. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

