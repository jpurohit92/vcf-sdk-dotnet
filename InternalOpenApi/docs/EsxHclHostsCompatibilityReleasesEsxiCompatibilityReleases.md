# Vcenter.Automation.OpenApi.Model.EsxHclHostsCompatibilityReleasesEsxiCompatibilityReleases
This Esx.Hcl.Hosts.CompatibilityReleases.EsxiCompatibilityReleases schema contains properties that describe available releases for generating compatibility report for a specific ESXi host.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentCompatibilityRelease** | **string** | The current release of the ESXi, which also can be checked for compatibility.    The information for the release does not include patch information. | 
**NewerCompatibilityReleases** | **List&lt;string&gt;** | The available ESXi releases, greater than the current one, than can be checked for compatibility. | 
**Notifications** | [**EsxHclNotifications**](EsxHclNotifications.md) | Notifications returned by the operation. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

