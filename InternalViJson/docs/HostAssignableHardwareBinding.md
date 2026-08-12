# Vcenter.ViJson.OpenApi.Model.HostAssignableHardwareBinding

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstanceId** | **string** | Instance ID of assigned device.  | 
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual machine to which the device is assigned.  Refers instance of *VirtualMachine*.  | 
**PciId** | **string** | The ID of the physical PCI (Peripheral Component Interconnect) device backing this binding.  More information about this particular PCI device can be found from the PciDevice object *HostPciDevice* with the same &#39;id&#39;.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**DeviceKey** | **int** | The device key of the virtual device this instanceId is assigned to.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

