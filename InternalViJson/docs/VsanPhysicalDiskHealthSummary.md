# Vcenter.ViJson.OpenApi.Model.VsanPhysicalDiskHealthSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OverallHealth** | **string** | The overall health status.  It&#39;s the aggregated health from all of disk&#39;s health status. All of possible values are red, yellow and green.  | 
**HeapsWithIssues** | [**List&lt;VsanResourceHealth&gt;**](VsanResourceHealth.md) | It includes all of vSAN heaps whose usage health is not green.  The health status will be red if the percentage of used heap space is larger 95%, the health status will be yellow if the percentage is in between of 75% and 95%.  | [optional] 
**SlabsWithIssues** | [**List&lt;VsanResourceHealth&gt;**](VsanResourceHealth.md) | It includes all of vSAN slabs whose usage health is not green.  The health status will be red if the usage percentage is larger 95% and the health status will be yellow if the percentage is in between of 75% and 95%  | [optional] 
**Disks** | [**List&lt;VsanPhysicalDiskHealth&gt;**](VsanPhysicalDiskHealth.md) | Per physical disk health result on the host  | [optional] 
**ComponentsWithIssues** | [**List&lt;VsanResourceHealth&gt;**](VsanResourceHealth.md) | It includes all of vSAN components whose health status is not in green  | [optional] 
**Hostname** | **string** | The host name  | [optional] 
**HostDedupScope** | **int** | The dedup scope configuration on the host.  The value 0 indicate there is no dedup enabled, 1 indicates the dedup scope is in disk wide and 2 indicates the dedup scope is in disk group wide.  | [optional] 
**Error** | [**MethodFault**](MethodFault.md) | If error is set, it means that collection of physical disk info failed on this host  | [optional] 
**LicensedDisks** | [**List&lt;VsanLicensedDiskResult&gt;**](VsanLicensedDiskResult.md) | A list of licensed vSAN disks result for all connected hosts.  The licensed disk&#39;s UUID, name and raw capacity are persisted during vSAN disk claiming for licensing purposes.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

