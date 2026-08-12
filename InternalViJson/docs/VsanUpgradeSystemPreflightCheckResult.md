# Vcenter.ViJson.OpenApi.Model.VsanUpgradeSystemPreflightCheckResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Issues** | [**List&lt;VsanUpgradeSystemPreflightCheckIssue&gt;**](VsanUpgradeSystemPreflightCheckIssue.md) | Detected issues.  In some cases, not all possible issues are captured, i.e. only the first (few) issues may be captured, and only once those are resolved would additional issues be reported. Absence of issues means the pre-flight check passed.  | [optional] 
**DiskMappingToRestore** | [**VsanHostDiskMapping**](VsanHostDiskMapping.md) | If the upgrade process was previously interrupted, it may have removed VSAN from a disk group, but not added the disk group back into VSAN.  If such a situation is detected, this field will be set and contains information about this disk group.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

