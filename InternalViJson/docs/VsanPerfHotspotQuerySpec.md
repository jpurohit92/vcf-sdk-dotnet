# Vcenter.ViJson.OpenApi.Model.VsanPerfHotspotQuerySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartTime** | **DateTime** | Indicates the start time of the time period to return the desired vSAN performance hostspot entities.  | 
**EndTime** | **DateTime** | Indicates the end time of the time period to return the desired vSAN performance hotspot entities.  | 
**Entity** | **string** | Represents the managed object type of the top entities, they are: virtual-machine, disk-group, host-domclient, host-domcompmgr and vsan-esa-disk-layer.  for detailed info, see *VsanPerformanceManager.VsanPerfQueryPerf*  | 
**MetricId** | **string** | Indicates which one metric is used to decide the order of the hotspot entities from resource consuming perspective.  The valid metric types for top entities query of entities virtual-machine, disk-group, host-domclient and host-domcompmgr include iopsRead, iopsWrite, throughputRead, throughputWrite, latencyRead, latencyWrite. The valid metric types of entity vsan-esa-disk-layer include iopsReadCapacity, iopsWriteCapacity, tputReadCapacity, tputWriteCapacity, avgLatReadCapacity, avgLatWriteCapacity  | 
**NumEntities** | **int** | Represents the number of the hotspot entities to be returned.  The default value is 10 and the maximum is 64.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

