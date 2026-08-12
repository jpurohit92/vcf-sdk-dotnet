# Vcenter.ViJson.OpenApi.Model.VirtualMachineVendorDeviceGroupInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The identification of the endpoint on the host.  The format of this depends on the kind of virtual device this endpoints is used for. For example, for a VirtualEthernetCard this would be a networkname, and for a VirtualCDROM it would be a device name.  | 
**ConfigurationTag** | **List&lt;string&gt;** | List of configurations that this device is available for.  This is only filled out if more than one configuration is requested.  | [optional] 
**DeviceGroupName** | **string** | Name of Vendor Device Group.  | 
**DeviceGroupDescription** | **string** | Description of Vendor Device Group.  | [optional] 
**ComponentDeviceInfo** | [**List&lt;VirtualMachineVendorDeviceGroupInfoComponentDeviceInfo&gt;**](VirtualMachineVendorDeviceGroupInfoComponentDeviceInfo.md) | Array describing component devices of this Vendor Device Group.  There is one entry per componentDevice in the deviceGroupSpec.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

