# Vcenter.ViJson.OpenApi.Model.SourceGroupInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | [**ReplicationGroupId**](ReplicationGroupId.md) | Identifier of the group + fault domain id.  | 
**Name** | **string** | Name of the replication group, may be edited after creating the Replication Group, not unique.  May be a localized string. Some vendors may choose to use name as the group id, to support this, vSphere will not allow the name to be modified - even if vSphere creates/manages the Replication Group.  | [optional] 
**Description** | **string** | Description the Replication Group, may be edited after creating the Replication Group.  May be a localized string.  | [optional] 
**State** | **string** | State of the replication group on the source.  | 
**Replica** | [**List&lt;ReplicationTargetInfo&gt;**](ReplicationTargetInfo.md) | Information about the target Replication Groups.  | [optional] 
**MemberInfo** | [**List&lt;SourceGroupMemberInfo&gt;**](SourceGroupMemberInfo.md) | Information about the member virtual volumes and their replicas.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

