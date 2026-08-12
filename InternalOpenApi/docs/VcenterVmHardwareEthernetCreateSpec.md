# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareEthernetCreateSpec
The Vcenter.Vm.Hardware.Ethernet.CreateSpec schema provides a specification for the configuration of a newly-created virtual Ethernet adapter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Ethernet adapter emulation type.  Possible values:   - &#x60;E1000&#x60;: E1000 ethernet adapter.   - &#x60;E1000E&#x60;: E1000e ethernet adapter.   - &#x60;PCNET32&#x60;: AMD Lance PCNet32 Ethernet adapter.   - &#x60;VMXNET&#x60;: VMware Vmxnet virtual Ethernet adapter.   - &#x60;VMXNET2&#x60;: VMware Vmxnet2 virtual Ethernet adapter.   - &#x60;VMXNET3&#x60;: VMware Vmxnet3 virtual Ethernet adapter.   For more information see: *Vcenter.Vm.Hardware.Ethernet.EmulationType*.  If missing or &#x60;null&#x60;, defaults to a guest-specific type. | [optional] 
**UptCompatibilityEnabled** | **bool** | Flag indicating whether Universal Pass-Through (UPT) compatibility is enabled on this virtual Ethernet adapter.  If missing or &#x60;null&#x60;, UPT will not be enabled on the newly-created virtual Ethernet adapter. | [optional] 
**UptV2CompatibilityEnabled** | **bool** | Flag indicating whether Uniform Pass-through version 2(UPTv2) compatibility is enabled on this network adapter. To enable this feature, the network adapter must connect to a network backed by DPU (Data Processing Unit) and network offloading must be enabled on the network.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60;, UPTv2 will not be enabled on the newly-created virtual Ethernet adapter. | [optional] 
**MacType** | **string** | MAC address type.  Possible values:   - &#x60;MANUAL&#x60;: MAC address is assigned statically.   - &#x60;GENERATED&#x60;: MAC address is generated automatically.   - &#x60;ASSIGNED&#x60;: MAC address is assigned by vCenter Server.   For more information see: *Vcenter.Vm.Hardware.Ethernet.MacAddressType*.  If missing or &#x60;null&#x60;, defaults to *Vcenter.Vm.Hardware.Ethernet.MacAddressType.GENERATED*. | [optional] 
**MacAddress** | **string** | MAC address.  Workaround for PR1459647 | [optional] 
**PciSlotNumber** | **long** | Address of the virtual Ethernet adapter on the PCI bus. If the PCI address is invalid, the server will change when it the VM is started or as the device is hot added.  If missing or &#x60;null&#x60;, the server will choose an available address when the virtual machine is powered on. | [optional] 
**WakeOnLanEnabled** | **bool** | Flag indicating whether wake-on-LAN is enabled on this virtual Ethernet adapter.  Defaults to false if missing or &#x60;null&#x60;. | [optional] 
**Backing** | [**VcenterVmHardwareEthernetBackingSpec**](VcenterVmHardwareEthernetBackingSpec.md) | Physical resource backing for the virtual Ethernet adapter.  If missing or &#x60;null&#x60;, the system may try to find an appropriate backing. If one is not found, the request will fail. | [optional] 
**StartConnected** | **bool** | Flag indicating whether the virtual device should be connected whenever the virtual machine is powered on.  Defaults to false if missing or &#x60;null&#x60;. | [optional] 
**AllowGuestControl** | **bool** | Flag indicating whether the guest can connect and disconnect the device.  Defaults to false if missing or &#x60;null&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

