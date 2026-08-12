# Vcenter.ViJson.OpenApi.Model.VsanHostRuntimeInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MembershipList** | [**List&lt;VsanHostMembershipInfo&gt;**](VsanHostMembershipInfo.md) | This property reports host membership information.  | [optional] 
**DiskIssues** | [**List&lt;VsanHostRuntimeInfoDiskIssue&gt;**](VsanHostRuntimeInfoDiskIssue.md) | List of disk issues detected on this host.  To retrieve more information on the issues, use *HostVsanSystem.QueryDisksForVsan*.  | [optional] 
**AccessGenNo** | **int** | Generation number tracking object accessibility.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

