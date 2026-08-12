# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesVcgEntriesProductSelectionSpec
The Esx.Settings.Clusters.Software.Reports.HardwareCompatibility.StorageDeviceOverrides.VcgEntries.ProductSelectionSpec schema contains information about the storage device and the corresponding Broadcom Compatibility Guide (BCG) product override that must be applied to the specified device.  This schema was added in __vSphere API 7.0.2.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | [**EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesVcgEntriesKey**](EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesVcgEntriesKey.md) | Information about the storage device for which this override must be applied to.  This property was added in __vSphere API 7.0.2.1__. | 
**VcgProduct** | **string** | Broadcom Compatibility Guide (BCG) product selection that must be applied to the specified storage device.  This property was added in __vSphere API 7.0.2.1__.  if missing or &#x60;null&#x60; any existing vcg selection for the storage device will be removed  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.vcg_product&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.vcg_product&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

