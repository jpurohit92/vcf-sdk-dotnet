# Vcenter.Automation.OpenApi.Model.EsxSettingsImageDetails
The Esx.Settings.ImageDetails schema contains details about the image.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifier of the Image. Valid identifier will be set only when the host is mapped to an alternative image. Identifier will be empty when the host is mapped to the default image.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.image&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.image&#x60;. | 
**Info** | [**EsxSettingsImageInfo**](EsxSettingsImageInfo.md) | Image information for the host.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

