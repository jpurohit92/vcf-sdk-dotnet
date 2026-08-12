# Vcenter.ViJson.OpenApi.Model.VsanClusterLimitHealthResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IssueFound** | **bool** | Whether any health issue was found  | 
**ComponentLimitHealth** | **string** | The component usage health status.  The status will be red if the used of component number exceeds 90% of total component number limit, the status will be yellow if it exceeds 80% of total component number and it will be green if it&#39;s less than 80% of total component number  | 
**DiskFreeSpaceHealth** | **string** | The aggregated result of the host level disk usage health status.  On one host, the status will be red if the used disk space is greater than 90% of the host&#39;s total space and the status will be yellow if the used percentage is greater than 70% and not greater than 90%. The status will be green if the used percentage is not greater than 70%.  | 
**RcFreeReservationHealth** | **string** | The read cache reservation health status.  The status will be red if the reserved read cache space is larger than 90% of total space, the status will be yellow if it&#39;s larger than 70% of total space and it will be green if it&#39;s less than 70% of total space  | 
**HostResults** | [**List&lt;VsanLimitHealthResult&gt;**](VsanLimitHealthResult.md) | Per host results.  Hosts for which the limit check failed will not be included.  | [optional] 
**WhatifHostFailures** | [**List&lt;VsanClusterWhatifHostFailuresResult&gt;**](VsanClusterWhatifHostFailuresResult.md) | Simulation results for 0, 1 or more host failures.  | [optional] 
**HostsCommFailure** | **List&lt;string&gt;** | Indicates names of hosts which are not able to communicate with  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

