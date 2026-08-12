# Vcenter.ViJson.OpenApi.Model.VirtualUSBUSBBackingInfo
The *VirtualUSBUSBBackingInfo* data object identifies a USB device on the host where the virtual machine is located.  This type of backing supports only a local connection where the virtual machine will remain on the host to which the USB device is attached.  To identify the USB device, you specify an autoconnect pattern for the *VirtualDeviceDeviceBackingInfo.deviceName*. The virtual machine can connect to the USB device if the ESX server can find a USB device described by the autoconnect pattern. The autoconnect pattern consists of name:value pairs. You can use any combination of the following fields. - path - USB connection path on the host - pid - idProduct field in the USB device descriptor - vid - idVendor field in the USB device descriptor - hostId - unique ID for the host - speed - device speed (low, full, or high)    For example, the following pattern identifies a USB device:  &nbsp;&nbsp;&nbsp;&nbsp;<code>\"path:1/3/0 hostId:44\\\\ 45\\\\ 4c\\\\ 43\\\\ 00\\\\ 10\\\\ 54-80\\\\ 35\\\\ ca\\\\ c0\\\\ 4f\\\\ 4d\\\\ 37\\\\ 31\"</code>  This pattern identifies the USB device connected to port 1/3/0 on the host with the unique id <code>0x44454c4c430010548035cac04f4d3731</code>.  Special characters for autoconnect pattern values: - The name and value are separated by a colon (:). - Name:value pairs are separated by spaces. - The escape character is a backslash (\\\\). Use a single backslash to embed   a space in a value. Use a double backslash to embed a single backslash   in the value. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceName** | **string** | The name of the device on the host system.  | 
**UseAutoDetect** | **bool** | Indicates whether the device should be auto detected instead of directly specified.  If this value is set to TRUE, deviceName is ignored.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

