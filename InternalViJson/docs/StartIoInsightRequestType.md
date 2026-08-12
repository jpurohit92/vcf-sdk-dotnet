# Vcenter.ViJson.OpenApi.Model.StartIoInsightRequestType
The parameters of *VsanIoInsightManager.StartIoInsight*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster to which the ESXi host(s) belong. This parameter is ignored while the API is called against host.  ***Required privileges:*** Global.Diagnostics  Refers instance of *ClusterComputeResource*.  | [optional] 
**RunName** | **string** | Caller can specify a meaningful name for ioinsight one time execution, and use that name for ioinsight metrics query in the future. This parameter can be ignored while the API is called against host.  | [optional] 
**DurationSec** | **long** | Duration in seconds for ioinsight execution. Once duration has expired ioinsight will stop on it&#39;s own. The valid range of duration is between from 60 second to 86400 seconds (24 hours). If this parameter is not provided, the API will try to append targetVMs to the ioinsight(s) running on targetHosts as new monitor targets.  | [optional] 
**TargetHosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | One or multiple ESXi hosts on which ioinsight is installed and going to be started. If this parameter is not provided, all hosts of the cluster will be treated as targets, and this case is only supported while being invoked against vCenter. If the API is called against host, this parameter is must to have and should be exactly same as the target host.  Refers instances of *HostSystem*.  | [optional] 
**TargetVMs** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | One or multiple target VMs will be monitored by ioinsight. If this parameter is not provided, all VMs on the host will be treated as targets.  Refers instances of *VirtualMachine*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

