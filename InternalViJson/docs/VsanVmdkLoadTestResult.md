# Vcenter.ViJson.OpenApi.Model.VsanVmdkLoadTestResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | True if the VMDK load test is succeeded.  | 
**FaultMessage** | **string** | The error message when there is any issue found.  | [optional] 
**Spec** | [**VsanVmdkLoadTestSpec**](VsanVmdkLoadTestSpec.md) | The spec for this result indicating the result is tested based on the spec.  | 
**ActualDurationSec** | **int** | The total duration time in second in the IO workload test.  | [optional] 
**TotalBytes** | **long** | The total read/write bytes in the IO workload test.  | [optional] 
**Iops** | **long** | The average Input/Output IO operations per second in the IO workload test.  | [optional] 
**TputBps** | **long** | The throughput in byte per second in the IO workload test.  | [optional] 
**AvgLatencyUs** | **long** | The average IO latency in microsecond in the IO workload test.  | [optional] 
**MaxLatencyUs** | **long** | The maximum IO latency in microsecond in the IO workload test.  | [optional] 
**NumIoAboveLatencyThreshold** | **long** | The number of IOs whose latency exceed the threshold as 5000 ms.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

