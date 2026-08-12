# Vcenter.ViJson.OpenApi.Model.VsanDiskFormatConversionSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataEfficiencyConfig** | [**VsanDataEfficiencyConfig**](VsanDataEfficiencyConfig.md) | Whether to enable or disable vSAN data efficiency from disk format layer.  | [optional] 
**DataEncryptionConfig** | [**VsanDataEncryptionConfig**](VsanDataEncryptionConfig.md) | vSAN encryption configuration parameters for disk format layer.  | [optional] 
**SkipHostRemediation** | **bool** | Do not perform host configuration remediation on hosts as part of the Disk Format Conversion.  Remediation is performed by default to ensure hosts are consistent. This will prevent errors as part of Disk Format Conversion due to inconsistent hosts. This field can be set to True when it is already known that all hosts are already consistent and have the latest configuration avoiding this extra step. Unset means False.  | [optional] 
**AllowDataMovement** | **bool** | Whether data movement is allowed for upcoming disk format conversion process.  If &#39;allowDataMovement&#39; is set to False, disk format conversion flow will check whether data movement is required. If disk format conversion need to move data to complete the operation, the *VsanDisallowDataMovementIssue* will fail the disk format conversion task.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

