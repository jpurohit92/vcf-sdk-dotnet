# Vcenter.Automation.OpenApi.Model.EsxSettingsRepositorySoftwareExportSpec
The Esx.Settings.Repository.Software.ExportSpec schema contains information describing how a software specification or image should be exported.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExportSoftwareSpec** | **bool** | Whether to export software specification document.  This property was added in __vSphere API 9.0.0.0__. | 
**ExportIsoImage** | **bool** | Whether to export ISO image.  This property was added in __vSphere API 9.0.0.0__. | 
**ExportOfflineBundle** | **bool** | Whether to export offline bundle.  This property was added in __vSphere API 9.0.0.0__. | 
**ExportOnlyDefaultImage** | **bool** | Whether to export only default image.  This property was added in __vSphere API 9.0.0.0__. | 
**SkipReservedVibsExport** | **bool** | Skip packaging of reserved VIBs in the exported offline-bundle/ISO. During effective VIB computation, a VIB at a lower version can get replaced by the same VIB at a higher version coming from another release unit. vLCM caches the lower version VIB in ESX-OSData partition to support extraction of currently running image from the hosts. Setting this option means (a) export will not package reserved VIBs, (b) the exported depot will be partial and remediation of images from such depots must be accompanied with com.vmware.esx.settings.clusters.policies.Apply.ConfiguredPolicySpec#skipReservedVibsCaching. Otherwise, the remediation might fail.   NOTE: Use this option with caution.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, reserved VIBs will be packaged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

