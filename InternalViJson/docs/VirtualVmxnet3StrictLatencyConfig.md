# Vcenter.ViJson.OpenApi.Model.VirtualVmxnet3StrictLatencyConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Allowed** | **bool** | Indicates whether strict latency configuration is allowed on this network adapter.  Requires VM hardware version compatible with ESXi release supporting the \&quot;real-time switch\&quot; feature.  | [optional] 
**MeasureLatency** | **bool** | Indicates whether the latency measurement is enabled.  The default value is \&quot;enabled\&quot;.  | [optional] 
**MaxTxQueues** | **int** | The number of transmit queues.  The default value is 1. The allowed range is 1 to 32, including.  | [optional] 
**MaxRxQueues** | **int** | The number of receive queues.  The default value is 1. The allowed range is 1 to 32, including.  | [optional] 
**TxDataRingDescSize** | **int** | The transmit data ring size.  The default value is 256. The allowed range is 128 to 2048, including, must be multiple of 64.  | [optional] 
**RxDataRingDescSize** | **int** | The receive data ring size.  The default value is 256. The allowed range is 128 to 2048, including, must be multiple of 64.  | [optional] 
**DisableOffload** | **string** | Type of disable offload being performed on the specified network adapter.  If not specified, TSO\\_LRO will be used as the default during adding new network adapter. The supported values are listed in *VirtualVmxnet3StrictLatencyConfigDisableOffload_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

