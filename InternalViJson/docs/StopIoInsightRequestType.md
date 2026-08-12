# Vcenter.ViJson.OpenApi.Model.StopIoInsightRequestType
The parameters of *VsanIoInsightManager.StopIoInsight*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster to which the target ESXi host(s) belong. This parameter is ignored while the API is called against host.  ***Required privileges:*** Global.Diagnostics  Refers instance of *ClusterComputeResource*.  | [optional] 
**RunName** | **string** | The name of running ioinsight to be stopped. This parameter can be ingnored while being called against host.  | [optional] 
**HostsIoInsightInfos** | [**List&lt;VsanHostIoInsightInfo&gt;**](VsanHostIoInsightInfo.md) | One or multiple host ioinsight(s) information, which indicate the target ioinsight(s) to be stopped or the VMs to be unmonitored. If *VsanIoInsightInfo.monitoredVMs* are specified by the parameter, the API will try to unmonitor the VMs from running ioinsight(s), otherwise it will entirely stop the specified ioinsight(s) if no valid runName is provided. If neither this parameter nor runName is provided, the API will try to stop ioinsight(s) on each host in the cluster, and this case is only supported while being invoked against vCenter. If the API is called against host, this parameter is must to have and *VsanHostIoInsightInfo.host* should be exactly same as the target host.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

