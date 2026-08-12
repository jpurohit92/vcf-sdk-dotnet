# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareEthernetBackingInfo
The Vcenter.Vm.Hardware.Ethernet.BackingInfo schema contains information about the physical resource backing a virtual Ethernet adapter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Backing type for the virtual Ethernet adapter.  Possible values:   - &#x60;STANDARD_PORTGROUP&#x60;: vSphere standard portgroup network backing.   - &#x60;HOST_DEVICE&#x60;: Legacy host device network backing. Imported VMs may have virtual Ethernet adapters with this type of backing, but this type of backing cannot be used to create or to update a virtual Ethernet adapter.   - &#x60;DISTRIBUTED_PORTGROUP&#x60;: Distributed virtual switch backing.   - &#x60;OPAQUE_NETWORK&#x60;: Opaque network backing.   For more information see: *Vcenter.Vm.Hardware.Ethernet.BackingType*. | 
**Network** | **string** | Identifier of the network backing the virtual Ethernet adapter.  If missing or &#x60;null&#x60;, the identifier of the network backing could not be determined.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;Network&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;Network&#x60;. | [optional] 
**NetworkName** | **string** | Name of the standard portgroup backing the virtual Ethernet adapter.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Ethernet.BackingType.STANDARD_PORTGROUP*. | [optional] 
**HostDevice** | **string** | Name of the device backing the virtual Ethernet adapter.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Ethernet.BackingType.HOST_DEVICE*. | [optional] 
**DistributedSwitchUuid** | **string** | UUID of the distributed virtual switch that backs the virtual Ethernet adapter.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Ethernet.BackingType.DISTRIBUTED_PORTGROUP*. | [optional] 
**DistributedPort** | **string** | Key of the distributed virtual port that backs the virtual Ethernet adapter.  This property will be missing or &#x60;null&#x60; if the virtual Ethernet device is not bound to a distributed virtual port; this can happen if the virtual machine is powered off or the virtual Ethernet device is not connected. | [optional] 
**ConnectionCookie** | **long** | Server-generated cookie that identifies the connection to the port. This cookie may be used to verify that the virtual machine is the rightful owner of the port.  This property will be missing or &#x60;null&#x60; if the virtual Ethernet device is not bound to a distributed virtual port; this can happen if the virtual machine is powered off or the virtual Ethernet device is not connected. | [optional] 
**OpaqueNetworkType** | **string** | Type of the opaque network that backs the virtual Ethernet adapter.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Ethernet.BackingType.OPAQUE_NETWORK*. | [optional] 
**OpaqueNetworkId** | **string** | Identifier of the opaque network that backs the virtual Ethernet adapter.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Ethernet.BackingType.OPAQUE_NETWORK*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

