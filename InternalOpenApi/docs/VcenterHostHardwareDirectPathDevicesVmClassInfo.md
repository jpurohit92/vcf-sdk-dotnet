# Vcenter.Automation.OpenApi.Model.VcenterHostHardwareDirectPathDevicesVmClassInfo
The Vcenter.Host.Hardware.DirectPathDevices.VmClassInfo schema provides information about VmClass using resources provided by a given DirectPath device.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Zone** | **string** | The zone associated with the VMClasses using resources from the device.  This property was added in __vSphere API 9.1.0.0__.  if missing or &#x60;null&#x60;, then this information is not available.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. | [optional] 
**ZoneName** | **string** | Zone name.  This property was added in __vSphere API 9.1.0.0__.  if missing or &#x60;null&#x60;, then this information is not available. | [optional] 
**VmClass** | **string** | VirtualMachineClass name.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.VirtualMachineClass&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.VirtualMachineClass&#x60;. | 
**DppId** | **string** | DirectPathProfile Id associated with this usage.  This property was added in __vSphere API 9.1.0.0__.  if missing or &#x60;null&#x60;, then this information is not available. | [optional] 
**VmClassReservedInUse** | **long** | Reservations in use for the VirtualMachineClass in the cluster the host belongs to.  This property was added in __vSphere API 9.1.0.0__.  if missing or &#x60;null&#x60;, then this information is not available. | [optional] 
**VmClassReservedTotal** | **long** | Total number of reservations done for the VMClass in the cluster the host belongs to.  This property was added in __vSphere API 9.1.0.0__.  if missing or &#x60;null&#x60;, then this information is not available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

