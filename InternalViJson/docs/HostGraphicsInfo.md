# Vcenter.ViJson.OpenApi.Model.HostGraphicsInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceName** | **string** | The device name.  | 
**VendorName** | **string** | The vendor name.  | 
**PciId** | **string** | PCI ID of this device composed of \&quot;bus:slot.function\&quot;.  | 
**GraphicsType** | **string** | Graphics type for this device.  See *HostGraphicsInfoGraphicsType_enum* for list of supported values.  | 
**VgpuMode** | **string** | vGPU mode for this device.  See *HostGraphicsInfoVgpuMode_enum* for list of supported values. If vgpuMode is not set, it is treated as value \&quot;none\&quot;.  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 
**MemorySizeInKB** | **long** | Memory capacity of graphics device or zero if not available.  | 
**Vm** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Virtual machines using this graphics device.  Refers instances of *VirtualMachine*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

