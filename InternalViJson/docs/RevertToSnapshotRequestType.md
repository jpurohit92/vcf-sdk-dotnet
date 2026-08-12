# Vcenter.ViJson.OpenApi.Model.RevertToSnapshotRequestType
The parameters of *VirtualMachineSnapshot.RevertToSnapshot_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | (optional) Choice of host for the virtual machine, in case this operation causes the virtual machine to power on.  If a snapshot was taken while a virtual machine was powered on, and this operation is invoked after the virtual machine was powered off, the operation causes the virtual machine to power on to reach the snapshot state. This parameter can be used to specify a choice of host where the virtual machine should power on.  If this parameter is not set and the vBalance feature is configured for automatic load balancing, a host is automatically selected. Otherwise, the virtual machine keeps its existing host affiliation.  Refers instance of *HostSystem*.  | [optional] 
**SuppressPowerOn** | **bool** | (optional) If set to true, the virtual machine will not be powered on regardless of the power state when the snapshot was created. Default to false.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

