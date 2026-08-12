# Vcenter.ViJson.OpenApi.Model.VsanPerfTopQuerySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TimeStamp** | **DateTime** | Indicate the sampling time to return the desired vSAN performance top entities.  | 
**Entity** | **string** | Represent the managed object type of the top entities, including virtual-machine, host-domclient, and host-domcompmgr.  In vSAN setup, it also includes disk-group.  | 
**MetricId** | **string** | Indicate which one metric is used to decide the order of the top entities from resource consuming perspective.  The valid metric types for top entities query, for virtual-machine, disk-group, host-domclient and host-domcompmgr, including iopsRead, iopsWrite, throughputRead, throughputWrite, latencyRead, latencyWrite.  | 
**NumEntities** | **int** | Represent the number of the top entities to be returned.  The default value is 10 and the maximum is 50.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

