# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareReportsHardwareCompatibilityPciDeviceOverridesVcgEntriesKey
The Esx.Settings.Clusters.Software.Reports.HardwareCompatibility.PciDeviceOverrides.VcgEntries.Key schema specifies a particular combination of PCI ID, specific FW version if known, Driver name, Driver version, and vSphere release for which a given override applies.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Device** | [**EsxSettingsClustersSoftwareReportsHardwareCompatibilityPciDeviceOverridesVcgEntriesPciDeviceIdentifier**](EsxSettingsClustersSoftwareReportsHardwareCompatibilityPciDeviceOverridesVcgEntriesPciDeviceIdentifier.md) | The PCI device ID  This property was added in __vSphere API 7.0.3.0__. | 
**FirmwareVersion** | **string** | The device firmware version  This property was added in __vSphere API 7.0.3.0__.  if not specified, the override applies to devices with an unknown firmware version. | [optional] 
**PartNumber** | **string** | OEM part number for device as used in BCG  This property was added in __vSphere API 7.0.3.0__.  if missing or &#x60;null&#x60; the override applies to devices without a part number. | [optional] 
**DriverName** | **string** | The name of the device driver for which this override applies  This property was added in __vSphere API 7.0.3.0__.  if missing or &#x60;null&#x60; the override applies to the specified device regardless of driver name. | [optional] 
**DriverVersion** | **string** | The version of the device driver for which this override applies (only accepted if &#39;driverName&#39; is also specified)  This property was added in __vSphere API 7.0.3.0__.  if missing or &#x60;null&#x60; the override applies to the specified device regardless of driver version. | [optional] 
**ProductId** | **string** | The Product ID for the device which this override applies (as presented by the device itself). May be left missing or &#x60;null&#x60; for devices that don&#39;t present a model number/product ID.  This property was added in __vSphere API 7.0.3.0__.  if missing or &#x60;null&#x60; the override applies to the specified device regardless of product ID. | [optional] 
**Capacity** | **long** | Storage device capacity (in bytes)  This property was added in __vSphere API 7.0.3.0__.  if missing or &#x60;null&#x60; the override applies to the specified device regardless of capacity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

