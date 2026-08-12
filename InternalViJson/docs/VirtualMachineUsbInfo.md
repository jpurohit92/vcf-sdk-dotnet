# Vcenter.ViJson.OpenApi.Model.VirtualMachineUsbInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The identification of the endpoint on the host.  The format of this depends on the kind of virtual device this endpoints is used for. For example, for a VirtualEthernetCard this would be a networkname, and for a VirtualCDROM it would be a device name.  | 
**ConfigurationTag** | **List&lt;string&gt;** | List of configurations that this device is available for.  This is only filled out if more than one configuration is requested.  | [optional] 
**Description** | **string** | A user visible name of the USB device.  | 
**Vendor** | **int** | The vendor ID of the USB device.  | 
**Product** | **int** | The product ID of the USB device.  | 
**PhysicalPath** | **string** | An autoconnect pattern which describes the device&#39;s physical path.  This is the path to the specific port on the host where the USB device is attached.  | 
**Family** | **List&lt;string&gt;** | The device class families.  For possible values see *VirtualMachineUsbInfoFamily_enum*  | [optional] 
**Speed** | **List&lt;string&gt;** | The possible device speeds detected by server.  For possible values see *VirtualMachineUsbInfoSpeed_enum*  | [optional] 
**Summary** | [**VirtualMachineSummary**](VirtualMachineSummary.md) | Summary information about the virtual machine that is currently using this device, if any.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

