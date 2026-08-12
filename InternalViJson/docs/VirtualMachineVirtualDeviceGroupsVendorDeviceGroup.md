# Vcenter.ViJson.OpenApi.Model.VirtualMachineVirtualDeviceGroupsVendorDeviceGroup

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupInstanceKey** | **int** | Group instance key.  Unique integer referencing device group. During group creation client should use a temporary negative number. Once group is added to the virtual machine, server generates non-negative integer that stays constant during group lifetime. See *VirtualDevice.key* for details.  | 
**DeviceInfo** | [**Description**](Description.md) | Provides a label and summary information for the device.  | [optional] 
**DeviceGroupName** | **string** | The name of the vendor device group from &lt;code&gt;*VirtualMachineVendorDeviceGroupInfo*&lt;/code&gt;.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

