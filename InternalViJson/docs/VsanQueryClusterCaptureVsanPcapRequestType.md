# Vcenter.ViJson.OpenApi.Model.VsanQueryClusterCaptureVsanPcapRequestType
The parameters of *VsanClusterHealthSystem.VsanQueryClusterCaptureVsanPcap*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hosts** | **List&lt;string&gt;** | The vSAN hosts  | 
**EsxRootPassword** | **string** | The root password for the host. The password should be the same for all of hosts in the vSAN cluster  | 
**Duration** | **int** | Duration to watch for packets in second. 1 minute is recommended  | 
**Vmknic** | [**List&lt;VsanClusterHostVmknicMapping&gt;**](VsanClusterHostVmknicMapping.md) | The map for host and the vmknic using for vSAN  | [optional] 
**IncludeRawPcap** | **bool** | True to include the raw pcap data in the result. Default is False  | [optional] 
**IncludeIgmp** | **bool** | True to include the IGMP network test data. Default is True  | [optional] 
**CmmdsMsgTypeFilter** | **List&lt;string&gt;** | The filter for vSAN message type. The network message whose type is not in the filter list will be ignored. All of the supported message types include \&quot;MASTER\\_HEARTBEAT\&quot;, \&quot;MASTER\\_UPDATE\&quot; and \&quot;AGENT\\_HEARTBEAT\&quot;.  | [optional] 
**CmmdsPorts** | **List&lt;int&gt;** | The vSAN multicast ports. Unset will use the default vSAN multicast ports.  | [optional] 
**ClusterUuid** | **string** | The vSAN cluster UUID.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

