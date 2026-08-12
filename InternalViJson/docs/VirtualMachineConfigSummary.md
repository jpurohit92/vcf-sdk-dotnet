# Vcenter.ViJson.OpenApi.Model.VirtualMachineConfigSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the virtual machine.  | 
**Template** | **bool** | Flag to determine whether or not this virtual machine is a template.  | 
**VmPathName** | **string** | Path name to the configuration file for the virtual machine  | 
**MemorySizeMB** | **int** | Memory size of the virtual machine, in megabytes.  | [optional] 
**CpuReservation** | **int** | Configured CPU reservation in MHz  | [optional] 
**MemoryReservation** | **int** | Configured Memory reservation in MB  | [optional] 
**NumCpu** | **int** | Number of processors in the virtual machine.  | [optional] 
**NumEthernetCards** | **int** | Number of virtual network adapters.  | [optional] 
**NumVirtualDisks** | **int** | Number of virtual disks attached to the virtual machine.  | [optional] 
**Uuid** | **string** | Virtual machine BIOS identification.  | [optional] 
**InstanceUuid** | **string** | VC-specific identifier of the virtual machine  | [optional] 
**GuestId** | **string** | Guest operating system identifier (short name).  | [optional] 
**GuestFullName** | **string** | Guest operating system name configured on the virtual machine.  | [optional] 
**Annotation** | **string** | Description for the virtual machine.  | [optional] 
**Product** | [**VAppProductInfo**](VAppProductInfo.md) | Product information.  References to properties in the URLs are expanded.  | [optional] 
**InstallBootRequired** | **bool** | Whether the VM requires a reboot to finish installation.  False if no vApp meta-data is configured.  | [optional] 
**FtInfo** | [**FaultToleranceConfigInfo**](FaultToleranceConfigInfo.md) | Fault Tolerance settings for this virtual machine.  This property will be populated only for fault tolerance virtual machines and will be left unset for all other virtual machines. See *FaultToleranceConfigInfo* for a description.  | [optional] 
**ManagedBy** | [**ManagedByInfo**](ManagedByInfo.md) | Specifies that this VM is managed by a VC Extension.  See the *managedBy* property in the ConfigSpec for more details.  | [optional] 
**TpmPresent** | **bool** | Is TPM present in a VM?  | [optional] 
**NumVmiopBackings** | **int** | Number of VMIOP backed devices attached to the virtual machine.  | [optional] 
**HwVersion** | **string** | The hardware version string for this virtual machine.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

