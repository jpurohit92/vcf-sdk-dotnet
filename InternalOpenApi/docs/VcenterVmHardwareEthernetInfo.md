# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareEthernetInfo
The Vcenter.Vm.Hardware.Ethernet.Info schema contains information about a virtual Ethernet adapter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | Device label. | 
**Type** | **string** | Ethernet adapter emulation type.  Possible values:   - &#x60;E1000&#x60;: E1000 ethernet adapter.   - &#x60;E1000E&#x60;: E1000e ethernet adapter.   - &#x60;PCNET32&#x60;: AMD Lance PCNet32 Ethernet adapter.   - &#x60;VMXNET&#x60;: VMware Vmxnet virtual Ethernet adapter.   - &#x60;VMXNET2&#x60;: VMware Vmxnet2 virtual Ethernet adapter.   - &#x60;VMXNET3&#x60;: VMware Vmxnet3 virtual Ethernet adapter.   For more information see: *Vcenter.Vm.Hardware.Ethernet.EmulationType*. | 
**UptCompatibilityEnabled** | **bool** | Flag indicating whether Universal Pass-Through (UPT) compatibility is enabled on this virtual Ethernet adapter.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Ethernet.EmulationType.VMXNE_t3*. | [optional] 
**UptV2CompatibilityEnabled** | **bool** | Flag indicates whether Uniform Pass-through version 2(UPTv2) compatibility is enabled on this network adapter.  This property was added in __vSphere API 8.0.0.1__.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Ethernet.EmulationType.VMXNE_t3*. | [optional] 
**MacType** | **string** | MAC address type.  Possible values:   - &#x60;MANUAL&#x60;: MAC address is assigned statically.   - &#x60;GENERATED&#x60;: MAC address is generated automatically.   - &#x60;ASSIGNED&#x60;: MAC address is assigned by vCenter Server.   For more information see: *Vcenter.Vm.Hardware.Ethernet.MacAddressType*. | 
**MacAddress** | **string** | MAC address.  May be missing or &#x60;null&#x60; if *Vcenter.Vm.Hardware.Ethernet.Info.mac_type* is *Vcenter.Vm.Hardware.Ethernet.MacAddressType.MANUAL* and has not been specified, or if *Vcenter.Vm.Hardware.Ethernet.Info.mac_type* is *Vcenter.Vm.Hardware.Ethernet.MacAddressType.GENERATED* and the virtual machine has never been powered on since the Ethernet adapter was created. | [optional] 
**PciSlotNumber** | **long** | Address of the virtual Ethernet adapter on the PCI bus. If the PCI address is invalid, the server will change it when the VM is started or as the device is hot added.  May be missing or &#x60;null&#x60; if the virtual machine has never been powered on since the adapter was created. | [optional] 
**WakeOnLanEnabled** | **bool** | Flag indicating whether wake-on-LAN is enabled on this virtual Ethernet adapter. | 
**Backing** | [**VcenterVmHardwareEthernetBackingInfo**](VcenterVmHardwareEthernetBackingInfo.md) | Physical resource backing for the virtual Ethernet adapter. | 
**State** | **string** | Connection status of the virtual device.  Possible values:   - &#x60;CONNECTED&#x60;: The device is connected and working correctly.   - &#x60;RECOVERABLE_ERROR&#x60;: Device connection failed due to a recoverable error; for example, the virtual device backing is currently in use by another virtual machine.   - &#x60;UNRECOVERABLE_ERROR&#x60;: Device connection failed due to an unrecoverable error; for example, the virtual device backing does not exist.   - &#x60;NOT_CONNECTED&#x60;: The device is not connected.   - &#x60;UNKNOWN&#x60;: The device status is unknown.   For more information see: *Vcenter.Vm.Hardware.ConnectionState*. | 
**StartConnected** | **bool** | Flag indicating whether the virtual device should be connected whenever the virtual machine is powered on. | 
**AllowGuestControl** | **bool** | Flag indicating whether the guest can connect and disconnect the device. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

