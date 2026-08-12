# Vcenter.ViJson.OpenApi.Model.DirectPathProfileInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the DirectPath profile.  | 
**Name** | **string** | Name of the DirectPath profile.  | 
**Description** | **string** | Description of the DirectPath profile.  | [optional] 
**VendorName** | **string** | Name of the vendor for the device represented by this DirectPath profile.  | 
**DeviceConfig** | [**DirectPathProfileManagerDirectPathConfig**](DirectPathProfileManagerDirectPathConfig.md) | Configuration of the DirectPath device represented by this DirectPath profile.  Since one DirectPath profile represents one device, the configuration will be one of the following types: 1\\) *DirectPathProfileManagerVmiopDirectPathConfig* 2\\) *DirectPathProfileManagerDvxDirectPathConfig* 3\\) *DirectPathProfileManagerDynamicDirectPathConfig* 4\\) *DirectPathProfileManagerVirtualDeviceGroupDirectPathConfig*  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

