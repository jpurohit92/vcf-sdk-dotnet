# Vcenter.ViJson.OpenApi.Model.HostNvmeDiscoveryLog

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entry** | [**List&lt;HostNvmeDiscoveryLogEntry&gt;**](HostNvmeDiscoveryLogEntry.md) | The list of entries that make up the Discovery Log.  | [optional] 
**Complete** | **bool** | Indicates whether the NvmeDiscoveryLog object completely represents the underlying Discovery Log returned by the controller.  It is possible some of the entries returned by the Discovery Controller contain unsupported transport types or data that cannot be interpreted - in that case, those entries will be skipped and the log will be marked as incomplete.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

