# Vcenter.ViJson.OpenApi.Model.VirtualMachineConfigOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | **string** | The version corresponding to this configOption.  | 
**Description** | **string** | A description string for this configOption.  | 
**GuestOSDescriptor** | [**List&lt;GuestOsDescriptor&gt;**](GuestOsDescriptor.md) | List of supported guest operating systems.  The choice of guest operating system may limit the set of valid devices. For example, you cannot select Vmxnet with all guest operating systems.  | 
**GuestOSDefaultIndex** | **int** | Index into guestOsDescriptor array denoting the default guest operating system.  | 
**HardwareOptions** | [**VirtualHardwareOption**](VirtualHardwareOption.md) | Processor, memory, and virtual device options for a virtual machine.  | 
**Capabilities** | [**VirtualMachineCapability**](VirtualMachineCapability.md) | Capabilities supported by a virtual machine.  | 
**Datastore** | [**DatastoreOption**](DatastoreOption.md) | The datastore options for this virtual machine.  | 
**DefaultDevice** | [**List&lt;VirtualDevice&gt;**](VirtualDevice.md) | The list of virtual devices that are created on a virtual machine by default.  Clients should not create these devices.  | [optional] 
**SupportedMonitorType** | **List&lt;string&gt;** | The monitor types supported by a host.  The acceptable monitor types are enumerated by *VirtualMachineFlagInfoMonitorType_enum*.  | 
**SupportedOvfEnvironmentTransport** | **List&lt;string&gt;** | Specifies the supported property transports that are available for the OVF environment  | [optional] 
**SupportedOvfInstallTransport** | **List&lt;string&gt;** | Specifies the supported transports for the OVF installation phase.  | [optional] 
**PropertyRelations** | [**List&lt;VirtualMachinePropertyRelation&gt;**](VirtualMachinePropertyRelation.md) | The relations between the properties of the virtual machine config spec.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

