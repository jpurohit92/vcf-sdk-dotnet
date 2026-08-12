# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareAlternativeImagesListResult
The ListResult schema contains the map of Image ID and ImageInfo of all the alternative images.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AlternativeImages** | [**Dictionary&lt;string, EsxSettingsImageInfo&gt;**](EsxSettingsImageInfo.md) | The map of Image ID and ImageInfo of all the alternative images.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.image&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.image&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

