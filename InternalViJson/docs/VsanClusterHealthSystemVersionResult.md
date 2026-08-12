# Vcenter.ViJson.OpenApi.Model.VsanClusterHealthSystemVersionResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostResults** | [**List&lt;VsanHostHealthSystemVersionResult&gt;**](VsanHostHealthSystemVersionResult.md) | The version information for all the hosts requested includes disconnected hosts and hosts without response.  | [optional] 
**VcVersion** | **string** | Return vSAN health service version number string on vCenter Server side.  If the query is not requested from vCenter Server, it will be unset.  | [optional] 
**IssueFound** | **bool** | True if the vSAN health service versions are inconsistent or query fails on some host.  | 
**UpgradePossible** | **bool** | True if the vSAN health service version can be upgraded on at least one host.  Takes into account which upgrade paths are supported, not just if the version is outdated.  | [optional] 
**VcBuild** | **string** | Return the build number of VMware vCenter.  If the query is not requested from vCenter Server, it will be unset.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

