# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesVcgEntriesKey
The Esx.Settings.Clusters.Software.Reports.HardwareCompatibility.StorageDeviceOverrides.VcgEntries.Key schema specifies information about the storage device for which this override must be applied to.  This schema was added in __vSphere API 7.0.2.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Model** | **string** | This property was added in __vSphere API 7.0.2.1__. | 
**Vendor** | **string** | This property was added in __vSphere API 7.0.2.1__. | 
**Capacity** | **long** | This property was added in __vSphere API 7.0.2.1__. | 
**PartNumber** | **string** | storage device part number  This property was added in __vSphere API 7.0.2.1__.  If missing or &#x60;null&#x60; the override will be applied to the entries without a part number. | [optional] 
**FirmwareVersion** | **string** | storage device firmware version  This property was added in __vSphere API 7.0.2.1__.  If missing or &#x60;null&#x60; the override is applied to all firmware versions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

