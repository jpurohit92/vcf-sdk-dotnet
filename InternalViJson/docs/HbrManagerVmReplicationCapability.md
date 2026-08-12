# Vcenter.ViJson.OpenApi.Model.HbrManagerVmReplicationCapability

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Refers instance of *VirtualMachine*.  | 
**SupportedQuiesceMode** | **string** | A string representing the current *QuiesceMode_enum* of the virtual machine.  | 
**CompressionSupported** | **bool** | Flag indicating compression support on the host on which this virtual machine is running.  | 
**MaxSupportedSourceDiskCapacity** | **long** | Maximum disk size supported (in bytes) on the host on which this virtual machine is running.  | 
**MinRpo** | **long** | Minimum rpo supported (in minutes) on the host on which this virtual machine is running.  | [optional] 
**Fault** | [**MethodFault**](MethodFault.md) | If we are unable to find the VM, we would set this to NotFound fault.  And, if we are unable to find the host for a given VM, then we would set this to HostNotReachable fault. Unset if we are able to fetch the capabilities for the VM.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

