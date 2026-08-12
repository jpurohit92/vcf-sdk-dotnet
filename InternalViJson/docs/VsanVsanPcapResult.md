# Vcenter.ViJson.OpenApi.Model.VsanVsanPcapResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Calltime** | **float** | The starting time for the vSAN multicast connectivity test  | 
**Vmknic** | **string** | The vmknic using for the vSAN multicast connectivity test  | 
**TcpdumpFilter** | **string** | The TCP packets filter to select which packets will be dumped.  The filter expression syntax is the same as the expression in the Linux standard utility command &#39;tcpdump&#39;  | 
**Snaplen** | **int** | The snapshot length is the amount of data for each frame that is actually captured in the multicast connectivity test  | 
**Pkts** | **List&lt;string&gt;** | The multicast network trace packets in the json format with the keys including \&quot;seenBy\&quot; (the host list which can communicate with this host), \&quot;cmmdsMcastSeq\&quot; (the CMMDS multicast packet sequence number), \&quot;dstIp\&quot; (the multicast destination IP), \&quot;srcUuid\&quot; (the source host UUID), \&quot;sentBy\&quot; (the host IP sending the multicast packet), \&quot;timestamp\&quot;, \&quot;srcPort\&quot; , \&quot;msgType\&quot;(the multicast packet message type), \&quot;srcIp\&quot;, \&quot;clusterUuid\&quot; (the vSAN cluster UUID), \&quot;pktType\&quot; (the packet type) and \&quot;dstPort\&quot;  | [optional] 
**Pcap** | **string** | The raw captured packet data with base64 encoding and is compressed as zip format  | [optional] 
**Error** | [**MethodFault**](MethodFault.md) | If error is set, it means that collection of Pcap info failed on this host  | [optional] 
**Hostname** | **string** | The host name  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

