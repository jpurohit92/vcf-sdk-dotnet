# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesComplianceStatusKey
The Esx.Settings.Clusters.Software.Reports.HardwareCompatibility.StorageDeviceOverrides.ComplianceStatus.Key schema specifies information about the storage device for which this override must be applied to.  This schema was added in __vSphere API 7.0.2.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Model** | **string** | This property was added in __vSphere API 7.0.2.1__. | 
**Vendor** | **string** | This property was added in __vSphere API 7.0.2.1__. | 
**Capacity** | **long** | This property was added in __vSphere API 7.0.2.1__. | 
**PartNumber** | **string** | storage device part number  This property was added in __vSphere API 7.0.2.1__.  If missing or &#x60;null&#x60; the override will be applied to the entries without a part number. | [optional] 
**FirmwareVersion** | **string** | storage device firmware version  This property was added in __vSphere API 7.0.2.1__.  If missing or &#x60;null&#x60; the override is applied to the entries with an unknown firmware version. | [optional] 
**DriverName** | **string** | Driver name of this storage device if applicable/available.  This property was added in __vSphere API 8.0.0.1__.  This property will be missing or &#x60;null&#x60; if there is no driver associated with the device. | [optional] 
**DriverVersion** | **string** | Driver version of this storage device if applicable/available.  This property was added in __vSphere API 8.0.0.1__.  This property will be missing or &#x60;null&#x60; if there is no driver associated with the device. | [optional] 
**Release** | **string** | vSphere release that an override must be applied to.  This property was added in __vSphere API 7.0.2.1__.  If this property is unset, *Vapi.Std.Errors.InvalidArgument* is thrown. The field is left optional to support wildcard matching in a future release. | [optional] 
**ValidatedFeaturesInUse** | [**Dictionary&lt;string, List&lt;string&gt;&gt;**](Set.md) | Validated features for which this override applies If a service is specified but no specific features are included, the device is taken to be in use by the service.  This property was added in __vSphere API 8.0.0.1__.  If this property is missing or &#x60;null&#x60; this is taken to mean that the device is active for the vSAN service (and no specific features). This is done in order to support 7.0 U3 clients which do not set this field. Subset of validated features for which we provide certification - for example RDMA, not IPV6 Note that this list represents the features in actual current use, which could include features for which the device is not certified | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

