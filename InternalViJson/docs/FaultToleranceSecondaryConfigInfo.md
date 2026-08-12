# Vcenter.ViJson.OpenApi.Model.FaultToleranceSecondaryConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Role** | **int** | The index of the current VM in instanceUuids array starting from 1, so 1 means that it is the primary VM.  | 
**InstanceUuids** | **List&lt;string&gt;** | The instanceUuid of all the VMs in this fault tolerance group.  The first element is the instanceUuid of the primary VM.  | 
**ConfigPaths** | **List&lt;string&gt;** | The configuration file path for all the VMs in this fault tolerance group.  | 
**Orphaned** | **bool** | Indicates whether a secondary VM is orphaned (no longer associated with the primary VM).  | [optional] 
**PrimaryVM** | [**ManagedObjectReference**](ManagedObjectReference.md) | Refers instance of *VirtualMachine*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

