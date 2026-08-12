# Vcenter.ViJson.OpenApi.Model.VirtualMachineSriovInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PciDevice** | [**HostPciDevice**](HostPciDevice.md) | Details of the PCI device, including vendor, class and device identification information.  | 
**SystemId** | **string** | The ID of the system the PCI device is attached to.  | 
**VirtualFunction** | **bool** | Indicates whether corresponding PCI device is a virtual function instantiated by a SR-IOV capable device.  | 
**Pnic** | **string** | The name of the physical nic that is represented by a SR-IOV capable physical function.  | [optional] 
**DevicePool** | [**VirtualMachineSriovDevicePoolInfo**](VirtualMachineSriovDevicePoolInfo.md) | SRIOV DevicePool information  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

