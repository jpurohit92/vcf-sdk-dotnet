# Vcenter.ViJson.OpenApi.Model.HostCapabilityFtUnsupportedReasonEnum
Deprecated as of vSphere API 7.0, use *VmFaultToleranceConfigIssueReasonForIssue_enum*.  Set of possible values for *HostCapability.ftCompatibilityIssues*  Possible values: - `vMotionNotLicensed`: No VMotion license - `missingVMotionNic`: VMotion nic is not configured on the host - `missingFTLoggingNic`: FT logging nic is not configured on the host - `ftNotLicensed`: Host does not have proper FT license - `haAgentIssue`: Host does not have HA agent running properly - `unsupportedProduct`: VMware product installed on the host does not support   fault tolerance - `cpuHvUnsupported`: Host CPU does not support hardware virtualization - `cpuHwmmuUnsupported`: Host CPU does not support hardware MMU virtualization - `cpuHvDisabled`: Host CPU is compatible for replay-based FT, but hardware   virtualization has been disabled in the BIOS. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

