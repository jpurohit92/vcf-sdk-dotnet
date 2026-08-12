# Vcenter.ViJson.OpenApi.Model.ClusterVmGroup

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Unique name of the group.  | 
**UserCreated** | **bool** | Flag to indicate whether the group is created by the user or the system.  | [optional] 
**UniqueID** | **string** | Unique ID for the group.  uniqueID is unique within a cluster. Groups residing in different clusters might share a uniqueID.  | [optional] 
**Vm** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | List of virtual machines that are part of this group.  A virtual machine group can contain zero or more virtual machines.  Refers instances of *VirtualMachine*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

