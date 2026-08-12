# Vcenter.ViJson.OpenApi.Model.VcRemoteVsanServerClusterInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterUuid** | **string** | The server cluster UUID which client cluster uses to mount remote vSAN datastores of server hosts.  | 
**NetworkTopology** | **string** | The network topology between the client and server cluster in the HCI Mesh configuration.  It is only needed when the server cluster is a stretched cluster on local vCenter.  See also *RemoteVsanNetworkTopology_enum*.  | [optional] 
**SiteAffinity** | [**List&lt;RemoteVsanSiteAffinity&gt;**](RemoteVsanSiteAffinity.md) | Site Affinity information between the client and server cluster.  This is only to be provided in case of the server cluster being a stretched cluster with two Fault Domains. The site affinity provided implies the network connectivity between the coupled sites to be a high bandwidth/ low latency link and the network connectivity between the uncoupled sites is assumed to be a low bandwidth high latency link. In case of a symmetric network connectivity between the client and server sites, this field can be left unset. A client site can only have one affinitized server site. A single server site can only be coupled with one client site. An empty list for siteAffinity will override the existing site affinity for the server cluster.  | [optional] 
**OwnerVc** | **string** | Remote vCenter identity which owns this server cluster.  This is used for remote vSAN across vCenter. The identity could be either FQDN or IP which is used to configure datastore source. This is only required during configuring remote data-in-transit encryption across vCenter. see *VsanRemoteVcInfo.vcHost*  | [optional] 
**DitConfig** | [**VsanDataInTransitEncryptionConfig**](VsanDataInTransitEncryptionConfig.md) | Data in transit encryption config between client and server cluster for remote vSAN.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

