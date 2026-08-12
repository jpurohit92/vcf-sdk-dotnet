# Vcenter.ViJson.OpenApi.Model.VsanHostQueryAdvCfgRequestType
The parameters of *HostVsanHealthSystem.VsanHostQueryAdvCfg*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Options** | **List&lt;string&gt;** | list of path for the configuration name for example: \\[VSAN.VsanSparseCacheThreshold, VSAN.ClomRepairDelay, VSAN.ClomRebalanceThreshold, VSAN.DomLongOpTraceMS...\\]  | 
**IncludeAllAdvOptions** | **bool** | Flag to check for all possible config options. If set to True the options parameter is ignored.  | [optional] 
**NonDefaultOnly** | **bool** | Flag to return only options with non-default values.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

