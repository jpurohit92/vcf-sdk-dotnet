# Vcenter.ViJson.OpenApi.Model.TestFailoverReplicationGroupStopRequestType
The parameters of *VasaProvider.TestFailoverReplicationGroupStop_Task*.  This structure may be used only with operations rendered under `/sms`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | [**List&lt;ReplicationGroupId&gt;**](ReplicationGroupId.md) | Array of replication groups that need to stop test.  | [optional] 
**Force** | **bool** | \\- if true, VP should force-unbind all Virtual Volumes and move the RG from INTEST to TARGET state. If false, VP will report all the Virtual Volumes which need to be cleaned up before a failover operation can be triggered. The default value will be false.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

