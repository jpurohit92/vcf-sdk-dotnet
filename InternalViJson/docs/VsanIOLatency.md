# Vcenter.ViJson.OpenApi.Model.VsanIOLatency

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LatencyType** | **string** | The type of latency measured.  See also *VsanIOLatencyType_enum*.  | 
**SourceEntityUuid** | **string** | The uuid of the object which sends the IO operation.  | 
**DestEntityUuid** | **string** | The uuid of the object which receives the IO operation.  | 
**ReadLatencyStats** | [**VsanIOLatencyMetrics**](VsanIOLatencyMetrics.md) | The latency stats for the read operations.  | 
**WriteLatencyStats** | [**VsanIOLatencyMetrics**](VsanIOLatencyMetrics.md) | The latency stats for the write operations.  | 
**DetailedInfo** | [**List&lt;KeyAnyValue&gt;**](KeyAnyValue.md) | The detailed additional info.  For \&quot;NetworkLatency\&quot;, it has fields \&quot;threshold\&quot; and \&quot;domComponentUuid\&quot;; For \&quot;LsomLatency\&quot;, it has field \&quot;domComponentUuid\&quot;; For \&quot;CapacityLsomLatency\&quot; or \&quot;PerfLsomLatency\&quot;, it has field \&quot;physicalDiskUuid\&quot;; For \&quot;CrossSiteNetworkLatency\&quot;, it has field \&quot;threshold\&quot;;  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

