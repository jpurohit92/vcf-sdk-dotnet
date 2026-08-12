# Vcenter.ViJson.OpenApi.Model.VsanNetworkLoadTestResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | The host name  | 
**Status** | **string** | The host network load test status.  For multicast, the status will be in red if the speed is less than 20 MB/s, the status will be yellow if the speed is between 20MB/s and 50MB/s and it&#39;s green if the speed is larger than 50MB/s; For unicast, the status will be red if the speed is 0 Mb/s, and yellow if the speed is less than 850 Mb/s, the status will be green if the speed is larger than or equal to 850 Mb/s.  | [optional] 
**VarClient** | **bool** | True indicates the host will act as the sender to send the network packets to other host(s) in the network performance test  | 
**BandwidthBps** | **long** | If the host acts as the sender, it&#39;s the value for the maximum achievable bandwidth and if the host acts as the receiver, it&#39;s the value for the actual network bandwidth in byte per second in the test  | 
**TotalBytes** | **long** | The total received or sent packet bytes in the network performance test  | 
**LostDatagrams** | **long** | The number of lost datagrams in the network performance test.  This value will only be set for the host acting as receiver  | [optional] 
**LossPct** | **long** | The percentage for the lost datagrams in the network performance test.  This value will only be set for the host acting as receiver  | [optional] 
**SentDatagrams** | **long** | The total number of sending datagrams in the network performance test.  This value will only be set for the host acting as receiver  | [optional] 
**JitterMs** | **float** | The network packet jitter in millisecond in the network performance test.  It shows the average packet latency between sender and receiver. This value will only be set for the host acting as receiver  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

