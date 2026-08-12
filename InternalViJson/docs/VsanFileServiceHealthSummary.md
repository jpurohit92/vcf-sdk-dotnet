# Vcenter.ViJson.OpenApi.Model.VsanFileServiceHealthSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | Hostname/IP of host which runs the file service health check.  | [optional] 
**OverallHealth** | **string** | Overall health state for vSAN file service configuration and runtime status for this host.  | [optional] 
**Enabled** | **bool** | Enable state for the vSAN file service on this host.  | [optional] 
**VdfsdStatus** | [**VsanResourceHealth**](VsanResourceHealth.md) | The health status of VDFS daemon for vSAN file service data service.  | [optional] 
**FsvmStatus** | [**VsanResourceHealth**](VsanResourceHealth.md) | The health status of File Service VM.  | [optional] 
**RootFsStatus** | [**VsanFileServiceRootFsHealth**](VsanFileServiceRootFsHealth.md) | The health status of Root File System.  | [optional] 
**FileServerHealth** | [**List&lt;VsanFileServerHealthSummary&gt;**](VsanFileServerHealthSummary.md) | The health status of file servers.  This health status includes liveness of file server IP addresses, accessibility of the root file system from file servers, etc.  | [optional] 
**FileShareHealth** | [**List&lt;VsanFileServiceShareHealthSummary&gt;**](VsanFileServiceShareHealthSummary.md) | The health status of file shares in this cluster.  | [optional] 
**BalanceStatus** | [**VsanFileServiceBalanceHealth**](VsanFileServiceBalanceHealth.md) | The health status of load balance of file servers in this cluster.  | [optional] 
**HostLoadStatus** | [**VsanResourceHealth**](VsanResourceHealth.md) | The load status of shares on this host.  Note: If hostLoadStatus is overloaded along with file server load balance issues, please rebalance the file shares via the remediation on vSAN health UI. Otherwise, consider adding more ESXi hosts to the cluster. This field will only work in a vSAN ESA cluster.  ***Since:*** 8.0.0.4  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

