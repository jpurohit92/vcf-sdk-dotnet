# Vcenter.ViJson.OpenApi.Model.VsanClusterHealthSystemStatusResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The current vSAN health cluster status.  Status &#39;green&#39; indicates all of hosts have been installed/uninstalled health service, &#39;yellow&#39; indicates the install or uninstall process is on going. &#39;red&#39; indicates not all of hosts in the cluster has been installed or uninstalled the health service successfully. This status should be used with goalState which indicates the service should be in installed or uninstalled state.  | 
**GoalState** | **string** | The target vSAN health cluster state.  Status &#39;installed&#39; or &#39;enabled&#39; indicated the health service should be enabled (all of hosts should have been installed health service), &#39;uninstalled&#39; indicates the health service should have been uninstalled/disabled (all of hosts should have been uninstalled health service).  | 
**UntrackedHosts** | **List&lt;string&gt;** | The host name list which are not traced by EAM.  | [optional] 
**TrackedHostsStatus** | [**List&lt;VsanHostHealthSystemStatusResult&gt;**](VsanHostHealthSystemStatusResult.md) | The EAM tracked host name list.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

