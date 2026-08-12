# Vcenter.ViJson.OpenApi.Model.VsanHostGetRuntimeStatsRequestType
The parameters of *VsanSystemEx.VsanHostGetRuntimeStats*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Stats** | **List&lt;string&gt;** | List of vSAN runtime stats type. Supported vSAN runtime stats types are declared in *VsanHostStatsType_enum*. If this parameter is omitted, all supported runtime stats will be collected and returned.  | [optional] 
**ClusterUuid** | **string** | The cluster uuid used for vSAN runtime stats of configGeneration in *VsanHostStatsType_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

