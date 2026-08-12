# Vcenter.ViJson.OpenApi.Model.VsanDiskFormatConversionCheckResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Issues** | [**List&lt;VsanUpgradeSystemPreflightCheckIssue&gt;**](VsanUpgradeSystemPreflightCheckIssue.md) | Detected issues.  In some cases, not all possible issues are captured, i.e. only the first (few) issues may be captured, and only once those are resolved would additional issues be reported. Absence of issues means the pre-flight check passed.  | [optional] 
**DiskMappingToRestore** | [**VsanHostDiskMapping**](VsanHostDiskMapping.md) | If the upgrade process was previously interrupted, it may have removed VSAN from a disk group, but not added the disk group back into VSAN.  If such a situation is detected, this field will be set and contains information about this disk group.  | [optional] 
**IsSupported** | **bool** | Whether vSAN could process disk format conversion on given cluster with specified conversion options.  If this field is set to false, please check the issues field to get the detailed reason which blocks disk format conversion.  | 
**TargetVersion** | **int** | Goal format version the given cluster could support.  The goal format version is up to the versions of ESXi hosts under given cluster, please reference to below: ESXi of vSphere6.0U2 and latter, supported version is 3 in upgrade process, and 2 in downgrade process; ESXi of vSphere6.0 series before vSphere6.0U2, supported version is 2 in upgrade process, and 1 in downgrade process; ESXi of lower version, is not supported;  | [optional] 
**IsDataMovementRequired** | **bool** | Whether data movement is required if disk format conversion process is triggered.  | [optional] 
**StoragePoolDisk** | **string** | Cannonical name of the disk removed by previous DFC but not added back.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

