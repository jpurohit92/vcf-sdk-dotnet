# Vcenter.ViJson.OpenApi.Model.HbrManagerReplicationVmInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **string** | A string representing the current *ReplicationVmState_enum* of the virtual machine.  | 
**ProgressInfo** | [**ReplicationVmProgressInfo**](ReplicationVmProgressInfo.md) | Progress stats for the current operation.  Never present if the state is not \&quot;syncing\&quot; or \&quot;active\&quot;. If not present while in one of these states, the host is still gathering initial operation statistics (progress can be assumed to be 0).  | [optional] 
**ImageId** | **string** | An optional imageId that identifies the instance being created, this is the imagId string that is passed to *HbrManager.HbrCreateInstance_Task* or *HbrManager.HbrStartOfflineInstance_Task*  | [optional] 
**LastError** | [**MethodFault**](MethodFault.md) | A MethodFault representing the last replication specific error that the *VirtualMachine* encountered during a create instance operation.  The successful creation of an instance will clear any error.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

