# Vcenter.ViJson.OpenApi.Model.HostPciDevice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The name ID of this PCI, composed of \&quot;bus:slot.function\&quot;.  | 
**ClassId** | **int** | The class of this PCI.  | 
**Bus** | **int** | The bus ID of this PCI.  | 
**Slot** | **int** | The slot ID of this PCI.  | 
**PhysicalSlot** | **int** | The physical slot of this PCI device  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**SlotDescription** | **string** | The slot description  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**Function** | **int** | The function ID of this PCI.  | 
**VendorId** | **int** | The vendor ID of this PCI.  The vendor ID might be a negative value. A vSphere Server uses an unsigned short integer to represent a PCI vendor ID. The WSDL representation of the ID is a signed short integer. If the vendor ID is greater than 32767, the Server will convert the ID to its two&#39;s complement for the WSDL representation. When you specify a PCI device vendor ID for a virtual machine (*VirtualPCIPassthroughDeviceBackingInfo*.vendorId), you must use the retrieved *HostPciDevice*.deviceId value.  | 
**SubVendorId** | **int** | The subvendor ID of this PCI.  The subvendor ID might be a negative value. A vSphere Server uses an unsigned short integer to represent a PCI subvendor ID. The WSDL representation of the ID is a signed short integer. If the subvendor ID is greater than 32767, the Server will convert the ID to its two&#39;s complement for the WSDL representation.  | 
**VendorName** | **string** | The vendor name of this PCI.  | 
**DeviceId** | **int** | The device ID of this PCI.  The device ID might be a negative value. A vSphere Server uses an unsigned short integer to represent a PCI device ID. The WSDL representation of the ID is a signed short integer. If the PCI ID is greater than 32767, the Server will convert the ID to its two&#39;s complement for the WSDL representation. When you specify a PCI device ID for a virtual machine (*VirtualPCIPassthroughDeviceBackingInfo*.deviceId), you must use the *HostPciDevice*.deviceId value as retrieved and convert it to a string.  | 
**SubDeviceId** | **int** | The subdevice ID of this PCI.  The subdevice ID might be a negative value. A vSphere Server uses an unsigned short integer to represent a PCI subdevice ID. The WSDL representation of the ID is a signed short integer. If the subdevice ID is greater than 32767, the Server will convert the ID to its two&#39;s complement for the WSDL representation.  | 
**ParentBridge** | **string** | The parent bridge of this PCI.  | [optional] 
**DeviceName** | **string** | The device name of this PCI.  | 
**DeviceClassName** | **string** | The name for the PCI device class representing this PCI.  For example: \&quot;Host bridge\&quot;, \&quot;iSCSI device\&quot;, \&quot;Fibre channel HBA\&quot;.  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 
**DirectPathInfo** | [**HostPciDeviceDirectPathInfo**](HostPciDeviceDirectPathInfo.md) | Information about physical device that can provide resources for virtual machines.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

