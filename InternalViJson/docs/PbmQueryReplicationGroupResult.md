# Vcenter.ViJson.OpenApi.Model.PbmQueryReplicationGroupResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | [**PbmServerObjectRef**](PbmServerObjectRef.md) | Reference to the virtual machine or virtual disk on which the query was performed.  If the query was performed for a virtual machine and all it&#39;s disks, this will reference each disk and the virtual machine config individually.  | 
**ReplicationGroupId** | [**ReplicationGroupId**](ReplicationGroupId.md) | Replication group identifier which is associated with &lt;code&gt;object&lt;/code&gt;.  | [optional] 
**Fault** | [**MethodFault**](MethodFault.md) | Fault associated with the query, if there is one.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

