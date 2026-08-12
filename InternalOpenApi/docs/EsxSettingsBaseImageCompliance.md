# Vcenter.Automation.OpenApi.Model.EsxSettingsBaseImageCompliance
The Esx.Settings.BaseImageCompliance schema contains information that describe the compliance of ESX base image with respect to the base image present in the target software specification.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Compliance status of the base image.  Possible values:   - &#x60;COMPLIANT&#x60;: Target version is same as current version.   - &#x60;NON_COMPLIANT&#x60;: Target version is greater than current version.   - &#x60;INCOMPATIBLE&#x60;: Target state cannot be applied due to conflict or missing dependencies or the target state is lesser than the current version.   - &#x60;UNAVAILABLE&#x60;: Drift check failed due to unknown error or check hasn&#39;t happened yet and results are not available.   For more information see: *Esx.Settings.ComplianceStatus*.  This property was added in __vSphere API 7.0.0.0__. | 
**StageStatus** | **string** | Stage status of the base image. This is only relevant when the value of *Esx.Settings.BaseImageCompliance.status* is *Esx.Settings.ComplianceStatus.NON_COMPLIANT*.  Possible values:   - &#x60;STAGED&#x60;: Required components/payloads are already staged.   - &#x60;NOT_STAGED&#x60;: Required components/payloads are not staged.   - &#x60;UNKNOWN&#x60;: Required components/payloads staged status is unknown.  This constant was added in __vSphere API 9.1.0.0__.   For more information see: *Esx.Settings.StageStatus*.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60; the staging status is unknown - the contents may or may not be staged. This can happen, for instance, if the stage check failed, has not been done yet, or the target uses an older interface that does not include support for returning the staged status. | [optional] 
**Current** | [**EsxSettingsBaseImageInfo**](EsxSettingsBaseImageInfo.md) | Current base image information on the host.  This property was added in __vSphere API 7.0.0.0__. | 
**Target** | [**EsxSettingsBaseImageInfo**](EsxSettingsBaseImageInfo.md) | Target base image information present in the software specification.  This property was added in __vSphere API 7.0.0.0__. | 
**Notifications** | [**EsxSettingsNotifications**](EsxSettingsNotifications.md) | Notifications describing the compliance result.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

