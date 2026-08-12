# Vcenter.ViJson.OpenApi.Model.TestFailoverParam
Input to testFailover method.  This structure may be used only with operations rendered under `/sms`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsPlanned** | **bool** | Whether the failover is a planned failover or not.  Note that testFailover can also be executed in an unplanned mode. When this flag is set to false, the recovery VASA provider must not try to connect to the primary VASA provider during the failover.  | 
**CheckOnly** | **bool** | Do not execute the (test) failover but check if the configuration is correct to execute the (test) failover.  If set to &lt;code&gt;true&lt;/code&gt;, the (test)failover result is an array where each element is either *GroupOperationResult* or *GroupErrorResult*.  If set to &lt;code&gt;false&lt;/code&gt;, the (test)failover result is an array where each element is either *FailoverSuccessResult* or *GroupErrorResult*.  | 
**ReplicationGroupsToFailover** | [**List&lt;ReplicationGroupData&gt;**](ReplicationGroupData.md) | The replication groups to failover.  It is OK for the VASA provider to successfully failover only some groups. The groups that did not complete will be retried.  | [optional] 
**PolicyAssociations** | [**List&lt;PolicyAssociation&gt;**](PolicyAssociation.md) | Storage policies for the devices after (test)failover.  Failover should be done even if policies cannot be associated. Test failover, however, should fail if policies cannot be associated.  If policies cannot be associated, VASA provider can notify the client by doing either or both of these: 1\\. Set the warning in the result for a replication group to indicate such a failure to set the policy. 2\\. Raise a compliance alarm after the failover is done.  If not specified, the default policies are used. Callers may reassign policy later.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

