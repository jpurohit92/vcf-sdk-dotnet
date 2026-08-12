# Vcenter.ViJson.OpenApi.Model.CreateSecondaryVMExRequestType
The parameters of *VirtualMachine.CreateSecondaryVMEx_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host where the secondary virtual machine is to be created and powered on. If no host is specified, a compatible host will be selected by the system. If a host cannot be found for the secondary or the specified host is not suitable, the secondary will not be created and a fault will be returned.  Refers instance of *HostSystem*.  | [optional] 
**Spec** | [**FaultToleranceConfigSpec**](FaultToleranceConfigSpec.md) | This parameter *FaultToleranceVMConfigSpec* can be used to specify the storage location of the fault tolerance tie-breaker file, secondary configuration file and secondary disks.  If the virtual machine is on a vSAN datastore, then the Fault Tolerance secondary virtual machine and the tie-breaker file also have to be placed on that same vSAN datastore. Conversely, if a primary VM is not using vSAN datastore, then its Fault Tolerance secondary virtual machine can not be placed on a vSAN datastore. Fault Tolerance is not supported for VMs that are using both vSAN and non-vSAN datastores for its configuration and disks.  If the virtual machine is using persistent memory for any of its disks, then its corresponding secondary disk placement entry should not be specified in the *FaultToleranceVMConfigSpec*. The system will automatically place the corresponding secondary disk on persistent memory.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

