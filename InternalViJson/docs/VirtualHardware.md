# Vcenter.ViJson.OpenApi.Model.VirtualHardware

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumCPU** | **int** | Number of virtual CPUs present in this virtual machine.  | 
**NumCoresPerSocket** | **int** | Number of cores used to distribute virtual CPUs among sockets in this virtual machine.  This field should be ignored for powered off VM with autoCoresPerSocket equals TRUE, because the virtual socket size will be assigned during power-on. This field could be unset for releases prior to 7.0 U3, and it implies numCoresPerSocket is 1. In other cases, this field represents the actual virtual socket size seen by the virtual machine.  | [optional] 
**AutoCoresPerSocket** | **bool** | Cores per socket is automatically determined.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**MemoryMB** | **int** | Memory size, in MB.  | 
**VirtualICH7MPresent** | **bool** | Does this virtual machine have Virtual Intel I/O Controller Hub 7  | [optional] 
**VirtualSMCPresent** | **bool** | Does this virtual machine have System Management Controller  | [optional] 
**Device** | [**List&lt;VirtualDevice&gt;**](VirtualDevice.md) | The set of virtual devices belonging to the virtual machine.  This list is unordered.  | [optional] 
**MotherboardLayout** | **string** | One of motherboardLayout choices.  Default is i440bxHostBridge. See *VirtualHardware.motherboardLayout*  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**SimultaneousThreads** | **int** | Number of SMT (Simultaneous multithreading) threads.  If unset, then system defaults are in use.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

