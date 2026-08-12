# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareReportsHardwareCompatibilityPciDeviceOverridesVcgEntriesProductSelectionSpec
The Esx.Settings.Clusters.Software.Reports.HardwareCompatibility.PciDeviceOverrides.VcgEntries.ProductSelectionSpec schema describes overrides for a given PCI device.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Target** | [**EsxSettingsClustersSoftwareReportsHardwareCompatibilityPciDeviceOverridesVcgEntriesKey**](EsxSettingsClustersSoftwareReportsHardwareCompatibilityPciDeviceOverridesVcgEntriesKey.md) | The PCI device this update should apply to.  This property was added in __vSphere API 7.0.3.0__. | 
**VcgProduct** | **string** | The BCG Product ID to be used.  This property was added in __vSphere API 7.0.3.0__.  if missing or &#x60;null&#x60;, the override is removed and the system reverts to matching the device to a BCG/HCL entry by PCI ID, device FW, driver, and driver version.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.vcg_product&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.vcg_product&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

