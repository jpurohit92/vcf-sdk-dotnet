# Vcenter.ViJson.OpenApi.Model.VsanNetworkHealthResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to host which ran the network health check  Refers instance of *HostSystem*.  | [optional] 
**Hostname** | **string** | Hostname/IP of host which ran the network health check.  | [optional] 
**VsanVmknicPresent** | **bool** | Whether or not the host which ran the health check had a vSAN vmknic configured.  | [optional] 
**IpSubnets** | **List&lt;string&gt;** | The IP subnets of vSAN vmknics configured on the host in the form: a.b.c.d/x  | [optional] 
**IssueFound** | **bool** | Any health issue found by the local host? Reason is contained in one of the other properties.  | [optional] 
**PeerHealth** | [**List&lt;VsanNetworkPeerHealthResult&gt;**](VsanNetworkPeerHealthResult.md) | Health of peer network connectivity as seen by the host which ran the check.  | [optional] 
**VMotionHealth** | [**List&lt;VsanNetworkPeerHealthResult&gt;**](VsanNetworkPeerHealthResult.md) | Perform a connectivity check for vMotion between this host and others.  | [optional] 
**MulticastConfig** | **string** | IP addresses used for multicast by vSAN.  This is meant as an opaque string, not to be parsed and the format to be relied on. The format may change in the future. The basic format for the multicast config is \&quot;agent group multicast IP/master group multicast IP\&quot; and will be concatenated by &#39;,&#39; if there are multiple vSAN vmknics.  | [optional] 
**UnicastConfig** | **string** | IP addresses used for unicast by vSAN in the format of JSON.  | [optional] 
**InUnicast** | **bool** | Host is using unicast or not.  | [optional] 
**RdmaEnabled** | **bool** | True indicates the host has enabled RDMA for data traffic in Reliable Datagram Transport (RDT) protocol  | [optional] 
**RdtConnProtocol** | **string** | The Reliable Datagram Transport (RDT) protocol used by host for vSAN data traffic.  vSAN supported RDT protocols include TCP, RoCEv1 and RoCEv2.  | [optional] 
**ServerClusters** | [**List&lt;VsanServerClusterInfo&gt;**](VsanServerClusterInfo.md) | Information of server vSAN clusters.  | [optional] 
**ExternalPeerHealth** | [**List&lt;VsanNetworkPeerHealthResult&gt;**](VsanNetworkPeerHealthResult.md) | Perform a connectivity check for vSAN client network between this host and others when vSAN MAX client network is enabled.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

