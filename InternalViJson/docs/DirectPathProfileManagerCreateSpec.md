# Vcenter.ViJson.OpenApi.Model.DirectPathProfileManagerCreateSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the DirectPath profile.  The name should be less than or equal to 80 characters.  | 
**Description** | **string** | Description of the DirectPath profile.  The description should be less than 256 characters.  | [optional] 
**DeviceConfig** | [**DirectPathProfileManagerDirectPathConfig**](DirectPathProfileManagerDirectPathConfig.md) | Configuration of the DirectPath device to be represented.  Since one DirectPath profile represents one device, the specified configuration can be one of the following types: 1\\) *DirectPathProfileManagerVmiopDirectPathConfig* 2\\) *DirectPathProfileManagerDvxDirectPathConfig* 3\\) *DirectPathProfileManagerDynamicDirectPathConfig* 4\\) *DirectPathProfileManagerVirtualDeviceGroupDirectPathConfig*  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

