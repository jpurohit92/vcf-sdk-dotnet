# Vcenter.ViJson.OpenApi.Model.TargetGroupInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | [**ReplicationGroupId**](ReplicationGroupId.md) | Identifier of the group + fault domain id.  | 
**SourceInfo** | [**TargetToSourceInfo**](TargetToSourceInfo.md) | Replication source information.  | 
**State** | **string** | Replication state of the group on the replication target.  | 
**Devices** | [**List&lt;TargetGroupMemberInfo&gt;**](TargetGroupMemberInfo.md) | Member device information.  When the ReplicationGroup is either in *FAILEDOVER* or *INTEST*, this should be *RecoveredTargetGroupMemberInfo*. Otherwise, this should be *TargetGroupMemberInfo*  | [optional] 
**IsPromoteCapable** | **bool** | Whether the VASA provider is capable of executing *VasaProvider.PromoteReplicationGroup_Task* for this ReplicationGroup.  False if not set. Note that this setting is per ReplicationGroup per Target domain.  | [optional] 
**Name** | **string** | Name of Replication Group.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

