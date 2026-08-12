# Vcenter.ViJson.OpenApi.Model.VirtualMachineVgpuProfileInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The identification of the endpoint on the host.  The format of this depends on the kind of virtual device this endpoints is used for. For example, for a VirtualEthernetCard this would be a networkname, and for a VirtualCDROM it would be a device name.  | 
**ConfigurationTag** | **List&lt;string&gt;** | List of configurations that this device is available for.  This is only filled out if more than one configuration is requested.  | [optional] 
**ProfileName** | **string** | The vGPU profile name.  | 
**DeviceVendorId** | **long** | A well-known unique identifier for the device that supports this profile.  It concatenates the 16-bit PCI vendor id in lower bits followed by 16-bit PCI device id.  | 
**FbSizeInGib** | **long** | The profile framebuffer size in gibibytes.  | 
**ProfileSharing** | **string** | Indicate how this profile is shared within device.  | 
**ProfileClass** | **string** | Indicate class for this profile.  | 
**StunTimeEstimates** | [**List&lt;VirtualMachineVMotionStunTimeInfo&gt;**](VirtualMachineVMotionStunTimeInfo.md) | VMotion stun time information for this profile.  ***Since:*** vSphere API Release 8.0.2.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

