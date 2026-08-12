# Vcenter.ViJson.OpenApi.Model.PhysicalNic

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The linkable identifier.  | [optional] 
**Device** | **string** | The device name of the physical network adapter.  | 
**Pci** | **string** | Device hash of the PCI device corresponding to this physical network adapter.  | 
**Driver** | **string** | The name of the driver.  From command line: esxcli network nic get  | [optional] 
**DriverVersion** | **string** | The version of the physical network adapter operating system driver.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**FirmwareVersion** | **string** | The version of the firmware running in the network adapter.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**LinkSpeed** | [**PhysicalNicLinkInfo**](PhysicalNicLinkInfo.md) | The current link state of the physical network adapter.  If this object is not set, then the link is down.  | [optional] 
**ValidLinkSpecification** | [**List&lt;PhysicalNicLinkInfo&gt;**](PhysicalNicLinkInfo.md) | The valid combinations of speed and duplexity for this physical network adapter.  The speed and the duplex settings usually must be configured as a pair. This array lists all the valid combinations available for a physical network adapter.  Autonegotiate is not listed as one of the combinations supported. If is implicitly supported by the physical network adapter unless *PhysicalNic.autoNegotiateSupported* is set to false.  | [optional] 
**Spec** | [**PhysicalNicSpec**](PhysicalNicSpec.md) | The specification of the physical network adapter.  | 
**WakeOnLanSupported** | **bool** | Flag indicating whether the NIC is wake-on-LAN capable  | 
**Mac** | **string** | The media access control (MAC) address of the physical network adapter.  | 
**FcoeConfiguration** | [**FcoeConfig**](FcoeConfig.md) | The FCoE configuration of the physical network adapter.  | [optional] 
**VmDirectPathGen2Supported** | **bool** | Deprecated as of vSphere API 8.0. VMDirectPath Gen 2 is no longer supported and there is no replacement.  Flag indicating whether the NIC supports VMDirectPath Gen 2.  Note that this is only an indicator of the capabilities of this NIC, not of the whole host.  If the host software is not capable of VMDirectPath Gen 2, this property will be unset, as the host cannot provide information on the NIC capability.  See also *HostCapability.vmDirectPathGen2Supported*.  | [optional] 
**VmDirectPathGen2SupportedMode** | **string** | Deprecated as of vSphere API 8.0. VMDirectPath Gen 2 is no longer supported and there is no replacement.  If *PhysicalNic.vmDirectPathGen2Supported* is true, this property advertises the VMDirectPath Gen 2 mode supported by this NIC (chosen from *PhysicalNicVmDirectPathGen2SupportedMode_enum*).  A mode may require that the associated vSphere Distributed Switch have a particular ProductSpec in order for network passthrough to be possible.  | [optional] 
**ResourcePoolSchedulerAllowed** | **bool** | Flag indicating whether the NIC allows resource pool based scheduling for network I/O control.  | [optional] 
**ResourcePoolSchedulerDisallowedReason** | **List&lt;string&gt;** | If *PhysicalNic.resourcePoolSchedulerAllowed* is false, this property advertises the reason for disallowing resource scheduling on this NIC.  The reasons may be one of *PhysicalNicResourcePoolSchedulerDisallowedReason_enum*  | [optional] 
**AutoNegotiateSupported** | **bool** | If set the flag indicates if the physical network adapter supports autonegotiate.  | [optional] 
**EnhancedNetworkingStackSupported** | **bool** | If set the flag indicates whether a physical nic supports Enhanced Networking Stack driver  | [optional] 
**EnsInterruptSupported** | **bool** | If set the flag indicates whether a physical nic supports Enhanced Networking Stack interrupt mode  | [optional] 
**RdmaDevice** | **string** | Associated RDMA device, if any.  | [optional] 
**DpuId** | **string** | The identifier of the DPU by which the physical NIC is backed.  When physical NIC is not backed by DPU, dpuId will be unset.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**PerfNicOffloadSupported** | **bool** | If set, the flag indicates whether a physical NIC supports performance NIC offloading.  If unset, the performance NIC offloading is not supported.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

