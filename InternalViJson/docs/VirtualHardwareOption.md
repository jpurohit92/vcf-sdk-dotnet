# Vcenter.ViJson.OpenApi.Model.VirtualHardwareOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HwVersion** | **int** | The virtual hardware version.  | 
**VirtualDeviceOption** | [**List&lt;VirtualDeviceOption&gt;**](VirtualDeviceOption.md) | Array of virtual device options valid for this virtual machine configuration.  The list is unordered.  | 
**DeviceListReadonly** | **bool** | Whether the set of virtual devices can be changed, e.g., can devices be added or removed.  This does not preclude changing devices.  | 
**NumCPU** | **List&lt;int&gt;** | List of acceptable values for the number of CPUs supported by this *ConfigOption*.  This is usually superseded by the information available in the guest operating system descriptors. The guest operating system descriptor describes a maximum CPU count, but the acceptable values are still constrained to the set specified here. The default value is stored at index 0 in the list.  | 
**NumCoresPerSocket** | [**IntOption**](IntOption.md) | The minimum, maximum and default number of cores per socket that can be used when distributing virtual CPUs.  | 
**AutoCoresPerSocket** | [**BoolOption**](BoolOption.md) | Whether auto cores per socket is supported.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**NumCpuReadonly** | **bool** | Can the number of virtual CPUs be changed  | 
**MemoryMB** | [**LongOption**](LongOption.md) | The minimum, maximum, and default memory options, in MB, per virtual machine, for this VirtualHardwareOption.  These values are typically overruled by the supported and recommended values specified in the *GuestOsDescriptor* class.  | 
**NumPCIControllers** | [**IntOption**](IntOption.md) | The minimum, maximum, and default number of PCI controllers for this virtual machine configuration.  | 
**NumIDEControllers** | [**IntOption**](IntOption.md) | The minimum, maximum, and default number of IDE controllers for this virtual machine configuration.  Note: SCSI controllers sit on the PCI controller so their options (minimum, maximum, and default values) are contained inside the *VirtualPCIControllerOption* class.  | 
**NumUSBControllers** | [**IntOption**](IntOption.md) | The minimum, maximum, and default number of USB controllers for this virtual machine configuration.  | 
**NumUSBXHCIControllers** | [**IntOption**](IntOption.md) | The minimum, maximum, and default number of XHCI (USB 3.0) controllers for this virtual machine configuration.  | 
**NumSIOControllers** | [**IntOption**](IntOption.md) | The minimum, maximum, and default number of SIO controllers for this virtual machine configuration.  | 
**NumPS2Controllers** | [**IntOption**](IntOption.md) | The minimum, maximum, and default number of PS2 controllers for this virtual machine configuration.  | 
**LicensingLimit** | **List&lt;string&gt;** | List of property names which limits are given be a licensing restriction of the underlying product, e.g., a limit that is not derived based on the product or hardware features.  For example, the property name \&quot;numCPU\&quot;  | [optional] 
**NumSupportedWwnPorts** | [**IntOption**](IntOption.md) | The minimum, maximum and default number of NPIV WorldWideNode names supported for this virtual machine configuration.  | [optional] 
**NumSupportedWwnNodes** | [**IntOption**](IntOption.md) | The minimum, maximum and default number of NPIV WorldWidePort names supported for this virtual machine configuration.  | [optional] 
**ResourceConfigOption** | [**ResourceConfigOption**](ResourceConfigOption.md) | Default value and value range for *ResourceConfigOption*  | 
**NumNVDIMMControllers** | [**IntOption**](IntOption.md) | The minimum, maximum and default number of virtual NVDIMM controllers for this virtual machine configuration.  | [optional] 
**NumTPMDevices** | [**IntOption**](IntOption.md) | The minimum, maximum, and default number of virtual TPMs.  | [optional] 
**NumWDTDevices** | [**IntOption**](IntOption.md) | The minimum, maximum, and default number of virtual watchdog timers.  | [optional] 
**NumPrecisionClockDevices** | [**IntOption**](IntOption.md) | The minimum, maximum and default number of PrecisionClock devices.  | [optional] 
**EpcMemoryMB** | [**LongOption**](LongOption.md) | The minimum, maximum and default value of Intel&#39;s Secure Guard Extensions Enclave Page Cache (EPC) memory.  | [optional] 
**AcpiHostBridgesFirmware** | **List&lt;string&gt;** | Empty for HWv17 &amp;amp; older, \\[\&quot;efi\&quot;\\] for HWv18.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**NumCpuSimultaneousThreads** | [**IntOption**](IntOption.md) | The minimum, maximum and default number of CPU simultaneous threads.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**NumNumaNodes** | [**IntOption**](IntOption.md) | The minimum, maximum and default number of NUMA nodes.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**NumDeviceGroups** | [**IntOption**](IntOption.md) | Maximum number of device groups.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**DeviceGroupTypes** | **List&lt;string&gt;** | Supported device group types.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

