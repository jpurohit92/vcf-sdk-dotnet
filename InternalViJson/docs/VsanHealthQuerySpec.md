# Vcenter.ViJson.OpenApi.Model.VsanHealthQuerySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncludeAllRemoteClusters** | **bool** | True to include all of server vSAN clusters mounted on the host.  This parameter will be ignored for network health check since network check only support one server cluster for each query.  | [optional] 
**RemoteClusterUuids** | **List&lt;string&gt;** | The server vSAN cluster UUIDs for query.  This parameter will be ignored if the includeAllRemoteClusters is set.  | [optional] 
**LatencyOnly** | **bool** | True to only check network latency of hosts between local and server vSAN cluster.  | [optional] 
**Mode** | **string** | Mode for vSAN.  Supported mode *VsanHostConfigInfoEx.mode*.  See also *VsanMode_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

