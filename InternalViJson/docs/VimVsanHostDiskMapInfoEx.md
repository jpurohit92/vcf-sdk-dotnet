# Vcenter.ViJson.OpenApi.Model.VimVsanHostDiskMapInfoEx

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mapping** | [**VsanHostDiskMapping**](VsanHostDiskMapping.md) | The disk structure of this vSAN disk group.  | 
**IsMounted** | **bool** | Whether this disk group is mounted to this host.  For an unmounted disk group, it cannot be used for vSAN I/O on this host. To make unmounted disk group contribute to vSAN I/O, please try vim.host.VsanSystem.InitializeDisks and vim.host.VsanSystem.AddDisks.  | 
**UnlockedEncrypted** | **bool** | Whether encryption keys for this disk group are loaded.  If vSAN encryption is on and the encryption keys are not loaded for the disk group, the disk group cannot be used for vSAN I/O on this host.  | [optional] 
**IsAllFlash** | **bool** | Whether this disk group is all flash disk group.  | 
**IsDataEfficiency** | **bool** | This field will be True if both vSAN deduplication and compression are enabled, or only compression is enabled on this disk group.  Check *VimVsanHostDiskMapInfoEx.dataEfficiencyConfig* for more details.  | [optional] 
**EncryptionInfo** | [**VsanDataEncryptionConfig**](VsanDataEncryptionConfig.md) | vSAN encryption metadata for the disk group.  | [optional] 
**DataEfficiencyConfig** | [**VsanDataEfficiencyConfig**](VsanDataEfficiencyConfig.md) | The data efficiency configuration on this disk group.  dedupEnabled in dataEfficiencyConfig will be set when both vSAN deduplication and compression are enabled. compressionEnabled in dataEfficiencyConfig will be set when compression-only is enabled. dedupEnabled and compressionEnabled will not be set at the same time (i.e. mutually-exclusive True). For more details refer to *VsanDataEfficiencyConfig*  | [optional] 
**DiskgroupCapability** | **List&lt;string&gt;** | vSAN diskgroup capability.  See *VsanDiskgroupCapability_enum* for all supported values.  See also *VsanDiskgroupCapability_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

