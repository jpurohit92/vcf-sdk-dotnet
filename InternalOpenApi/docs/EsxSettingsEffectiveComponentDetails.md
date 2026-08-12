# Vcenter.Automation.OpenApi.Model.EsxSettingsEffectiveComponentDetails
The Esx.Settings.EffectiveComponentDetails schema contains information that provide more details about the component from the depot.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Display name of the component.  This property was added in __vSphere API 7.0.0.0__. | 
**DisplayVersion** | **string** | Human readable version of the component.  This property was added in __vSphere API 7.0.0.0__. | 
**Vendor** | **string** | Vendor of the component.  This property was added in __vSphere API 7.0.0.0__. | 
**Source** | **string** | Final effective source of the component.  Possible values:   - &#x60;BASE_IMAGE&#x60;: Base image is the source for this component   - &#x60;ADD_ON&#x60;: Addon is the source for this component   - &#x60;USER&#x60;: User is the source for this component   - &#x60;SOLUTION&#x60;: Solution is the source for this component   - &#x60;HARDWARE_SUPPORT_PACKAGE&#x60;: Hardware Support Package (HSP) is the source for this component  This constant was added in __vSphere API 7.0.0.0__.   - &#x60;USER_REMOVED&#x60;: This component was removed by the user  This constant was added in __vSphere API 8.0.3.0__.   For more information see: *Esx.Settings.ComponentSource*.  This property was added in __vSphere API 7.0.0.0__. | 
**Note** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Note assosicated with this component.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, note is present for this component. | [optional] 
**OverriddenComponents** | [**List&lt;EsxSettingsComponentOverrideInfo&gt;**](EsxSettingsComponentOverrideInfo.md) | List of other component versions present in base image, add-ons or solutions that this component is overriding. For example, if a component version-1 was implicitly present in the base image, but user wants it to be changed to version-2. In that case, *Esx.Settings.EffectiveComponentDetails.source* would be USER and there will be one entry in this list indicating base image component version-1 is being overridden.  This property was added in __vSphere API 7.0.0.0__. | 
**Removable** | **bool** | Flag to indicate if the component can be removed by specifying its name in the removed components section of the software specification.  This property was added in __vSphere API 8.0.3.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**ImageCustomizationAction** | **string** | Image customization status for the current component.  Possible values:   - &#x60;RETAINED&#x60;: The component is retained at an older version in the desired software specification.   - &#x60;REMOVED&#x60;: The component is removed by the user in the desired software specification.   For more information see: *Esx.Settings.ImageCustomizationAction*.  This property was added in __vSphere API 8.0.3.0__.  if missing or &#x60;null&#x60; the component is not customized. | [optional] 
**ImageCustomizationDescription** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Localized text describing the imageCustomizationAction.  This property was added in __vSphere API 8.0.3.0__.  if missing or &#x60;null&#x60; the component is not customized. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

