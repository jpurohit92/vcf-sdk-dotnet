# Vcenter.ViJson.OpenApi.Model.VsanClusterConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Config** | [**VsanClusterConfigInfo**](VsanClusterConfigInfo.md) | The vSAN configuration of the cluster, to present vSAN&#39;s enablement, cluster UUID, and auto-claim setting.  | 
**Name** | **string** | A user friendly name for the cluster.  Must be unique.  | 
**Hosts** | **List&lt;string&gt;** | Host BIOS UUIDs of hosts that are configured by user to be part of this cluster.  | [optional] 
**ToBeDeleted** | **bool** | Indicates whether this cluster is being deleted.  If toBeDeleted is set True, then no Host will be added to this cluster. Default: False.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

