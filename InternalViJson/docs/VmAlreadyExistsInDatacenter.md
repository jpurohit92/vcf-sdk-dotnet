# Vcenter.ViJson.OpenApi.Model.VmAlreadyExistsInDatacenter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Target** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to invalid target.  Refers instance of *ManagedEntity*.  | 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target host.  Refers instance of *HostSystem*.  | 
**Hostname** | **string** | Name of the target host.  | 
**Vm** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Virtual machines in the target datacenter which have the same registration information as those belonging to the target host.  Refers instances of *VirtualMachine*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

