# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesComplianceStatusReclassificationSpec
The Esx.Settings.Clusters.Software.Reports.HardwareCompatibility.StorageDeviceOverrides.ComplianceStatus.ReclassificationSpec schema contains information about the storage device and the corresponding override that must be applied to the specified device. Note: This data structure is specifically limited to a 'Key'/'Value' pair to model smaller changes to the larger overall set of overrides applicable to a given storage device  This schema was added in __vSphere API 7.0.2.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | [**EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesComplianceStatusKey**](EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesComplianceStatusKey.md) | Information about the storage device for which this override must be applied to.  This property was added in __vSphere API 7.0.2.1__. | 
**Override** | **string** | Compliance status override for the storage device.  Possible values:   - &#x60;MARK_AS_VERIFIED&#x60;: Specifying this override for a storage device would ignore the compatibility issues if any, and treat the drive as compliant with Broadcom Compatibility Guide (BCG)   - &#x60;FLAG_AS_INCOMPATIBLE&#x60;: Specifying this override for a storage device would flag the drive as non-compliant with Broadcom Compatibility Guide (BCG)   - &#x60;SUPPRESS_WARNING&#x60;: Specifying this override for a storage device would suppress the compatibility issues if any.   For more information see: *Esx.Settings.Clusters.Software.Reports.HardwareCompatibility.StorageDeviceOverrides.ComplianceStatus.ComplianceAction*.  This property was added in __vSphere API 7.0.2.1__.  If this property is missing or &#x60;null&#x60; any existing compliance override for the specified device will be reset. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

