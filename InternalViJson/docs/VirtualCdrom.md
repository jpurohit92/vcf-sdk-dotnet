# Vcenter.ViJson.OpenApi.Model.VirtualCdrom
The VirtualCdrom data object type describes the configuration of a CD-ROM device in a virtual machine. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | A unique key that distinguishes this device from other devices in the same virtual machine.  Keys are immutable but may be recycled; that is, a key does not change as long as the device is associated with a particular virtual machine. However, once a device is removed, its key may be used when another device is added.  This property is not read-only, but the client cannot control its value. Persistent device keys are always assigned and managed by the server, which guarantees that all devices will have non-negative key values.  When adding new devices, it may be necessary for a client to assign keys temporarily in order to associate controllers with devices in configuring a virtual machine. However, the server does not allow a client to reassign a device key, and the server may assign a different value from the one passed during configuration. Clients should ensure that existing device keys are not reused as temporary key values for the new device to be added (for example, by using unique negative integers as temporary keys).  When editing or deleting a device, clients must use the server-provided key to refer to an existing device.  | 
**DeviceInfo** | [**Description**](Description.md) | Provides a label and summary information for the device.  | [optional] 
**Backing** | [**VirtualDeviceBackingInfo**](VirtualDeviceBackingInfo.md) | Information about the backing of this virtual device presented in the context of the virtual machine&#39;s environment.  Not all devices are required to have backing information.  See also *VirtualMachineConfigOption*.  | [optional] 
**Connectable** | [**VirtualDeviceConnectInfo**](VirtualDeviceConnectInfo.md) | Provides information about restrictions on removing this device while a virtual machine is running.  If the device is not removable, then this property is null.  | [optional] 
**SlotInfo** | [**VirtualDeviceBusSlotInfo**](VirtualDeviceBusSlotInfo.md) | Information about the bus slot of a device in a virtual machine.  | [optional] 
**ControllerKey** | **int** | Object key for the controller object for this device.  This property contains the key property value of the controller device object.  | [optional] 
**UnitNumber** | **int** | The unit number of this device on its controller.  This property is null if the controller property is null (for example, when the device is not attached to a specific controller object).  Normally, two devices on the same controller may not be assigned the same unit number. If multiple devices could exist on a controller, then unit number has to be specified to configure respective devices.  | [optional] 
**NumaNode** | **int** | The virtual NUMA node.  A negative number means there is no affinity for the device. A positive number is a vNUMA node. An unset value of numaNode is status-quo during Reconfigure time. If numaNode is unset during ConfigInfo, then it means there is no affinity for the device.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**DeviceGroupInfo** | [**VirtualDeviceDeviceGroupInfo**](VirtualDeviceDeviceGroupInfo.md) | Information about device group device is part of.  Devices in the device group cannot be added/removed individually, whole group has to be added/removed at once. Value can be set during device add, it cannot be modified later.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

