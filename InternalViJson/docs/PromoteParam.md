# Vcenter.ViJson.OpenApi.Model.PromoteParam

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsPlanned** | **bool** | Specifies whether the promote operation is a planned one.  When this flag is set to false, the recovery VASA provider must not try to connect to the primary VASA provider during promote.  | 
**ReplicationGroupsToPromote** | [**List&lt;ReplicationGroupId&gt;**](ReplicationGroupId.md) | The replication groups to promote.  It is legal for the VASA provider to successfully promote only some groups. The groups that did not succeed will be retried.  The identifiers of the Virtual Volumes do not change after the promote operation.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

