# Vcenter.ViJson.OpenApi.Model.VsanVsanClusterPcapResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Pkts** | **List&lt;string&gt;** | The multicast network trace packets in the json format with the keys including \&quot;seenBy\&quot; (the host list which can communicate with this host), \&quot;cmmdsMcastSeq\&quot; (the CMMDS multicast packet sequence number), \&quot;dstIp\&quot; (the multicast destination IP), \&quot;srcUuid\&quot; (the source host UUID), \&quot;sentBy\&quot; (the host IP sending the multicast packet), \&quot;timestamp\&quot;, \&quot;srcPort\&quot; , \&quot;msgType\&quot;(the multicast packet message type), \&quot;srcIp\&quot;, \&quot;clusterUuid\&quot; (the vSAN cluster UUID), \&quot;pktType\&quot; (the packet type) and \&quot;dstPort\&quot;  | [optional] 
**Groups** | [**List&lt;VsanVsanClusterPcapGroup&gt;**](VsanVsanClusterPcapGroup.md) | The Pcap group result  | [optional] 
**Issues** | **List&lt;string&gt;** | The issue list contains the potential mutlicast communication issue between two communication entities with plain string format\&quot;  | [optional] 
**HostResults** | [**List&lt;VsanVsanPcapResult&gt;**](VsanVsanPcapResult.md) | Per host result for the vSAN multicast connectivity test  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

