# Vcenter.ViJson.OpenApi.Model.VsanServerClusterInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The server vSAN cluster.  It&#39;s unset for health result returned from host.  Refers instance of *ClusterComputeResource*.  | [optional] 
**PeerHealth** | [**List&lt;VsanNetworkPeerHealthResult&gt;**](VsanNetworkPeerHealthResult.md) | Network health details for each host of server vSAN cluster.  | [optional] 
**Membership** | [**VsanClusterMembershipInfo**](VsanClusterMembershipInfo.md) | The vSAN cluster membership information for the server vSAN clusters mounted on the host.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

