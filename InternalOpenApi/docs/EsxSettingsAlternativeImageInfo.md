# Vcenter.Automation.OpenApi.Model.EsxSettingsAlternativeImageInfo
The Esx.Settings.AlternativeImageInfo schema contains properties that describes an alternative image for the desired software specification.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseImage** | [**EsxSettingsBaseImageInfo**](EsxSettingsBaseImageInfo.md) | Base image of the ESX.  This property was added in __vSphere API 9.0.0.0__. | 
**AddOn** | [**EsxSettingsAddOnInfo**](EsxSettingsAddOnInfo.md) | OEM customization on top of given base image. The components in this customization override the components in the base base image.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no OEM customization will be applied. | [optional] 
**Components** | [**Dictionary&lt;string, EsxSettingsComponentInfo&gt;**](EsxSettingsComponentInfo.md) | Information about the components in the software specification.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.component&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.component&#x60;. | 
**Solutions** | [**Dictionary&lt;string, EsxSettingsSolutionInfo&gt;**](EsxSettingsSolutionInfo.md) | Information about the solutions in the software specification.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.solution&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.solution&#x60;. | 
**HardwareSupport** | [**EsxSettingsHardwareSupportInfo**](EsxSettingsHardwareSupportInfo.md) | Information about the Hardware Support Packages (HSP) configured.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no Hardware Support Package (HSP) is specified for the cluster. | [optional] 
**RemovedComponents** | [**Dictionary&lt;string, EsxSettingsComponentInfo&gt;**](EsxSettingsComponentInfo.md) | Information about the components to be removed in the software specification.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no removed component is specified for the cluster.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.component&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.component&#x60;. | [optional] 
**DisplayName** | **string** | Display name of the Alternative Image. Supported encoding is UTF-8.  This property was added in __vSphere API 9.0.0.0__. | 
**SelectionCriteria** | [**EsxSettingsImageSelectionInfo**](EsxSettingsImageSelectionInfo.md) | Selection criteria used to select the alternative image for 1 or more hosts  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

