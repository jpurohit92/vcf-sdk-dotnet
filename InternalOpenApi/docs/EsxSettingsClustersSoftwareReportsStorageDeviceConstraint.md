# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareReportsStorageDeviceConstraint
The StorageHclConstraint schema contains information about Storage device's hardware compatibility certification including details like driver and/or firmware versions and the set of validated features supported  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirmwareVersion** | **string** | Certified Firmware Version.  This property was added in __vSphere API 8.0.0.1__.  This property will be missing or &#x60;null&#x60;- If there is no firmware version specified for the device | [optional] 
**FirmwareVersionMatch** | **string** | Criteria for matching firmware version  Possible values:   - &#x60;EXACT&#x60;: Firmware version is matched to exact version specified   - &#x60;MINIMUM&#x60;: Firmware version is matched to be at least minimum version specified   For more information see: *Esx.Settings.Clusters.Software.Reports.FirmwareVersionMatchingCriteria*.  This property was added in __vSphere API 8.0.0.1__.  This property will be missing or &#x60;null&#x60; when firmware version is not set | [optional] 
**DriverName** | **string** | Certified Driver Name.  This property was added in __vSphere API 8.0.0.1__.  This property will be missing or &#x60;null&#x60; If there is no driver certification for the device | [optional] 
**DriverVersion** | **string** | Certified Driver Version.  This property was added in __vSphere API 8.0.0.1__.  This property will be missing or &#x60;null&#x60; If there is no driver certification for the device | [optional] 
**SupportedFeatures** | [**Dictionary&lt;string, List&lt;string&gt;&gt;**](Set.md) | Map of solutions and the corresponding features that the device is certified for in the Broadcom Compatibility Guide If map is empty, device is not certified for any specific solutions like vSAN If Service is set but features are empty, means device is certified for solution. If Service is set and features is also set, means device is certified for specific features.  This property was added in __vSphere API 8.0.0.1__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

