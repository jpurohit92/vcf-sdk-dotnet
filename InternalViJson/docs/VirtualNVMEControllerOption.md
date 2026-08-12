# Vcenter.ViJson.OpenApi.Model.VirtualNVMEControllerOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Devices** | [**IntOption**](IntOption.md) | The minimum and maximum number of devices this controller can control at run time.  | 
**SupportedDevice** | **List&lt;string&gt;** | Array of supported device options for this controller.  | [optional] 
**NumNVMEDisks** | [**IntOption**](IntOption.md) | Three properties (numNVMEDisks.min, numNVMEDisks.max, and numNVMEDisks.defaultValue) define the minimum, maximum, and default number of NVME VirtualDisk instances available at any given time in the NVME controller.  The number of NVME VirtualDisk instances is also limited by the number of available namespaces in the NVME controller.  | 
**Sharing** | **List&lt;string&gt;** | Supported shared bus modes.  See *VirtualNVMEControllerSharing_enum* for the list of available modes.  ***Since:*** vSphere API Release 8.0.2.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

