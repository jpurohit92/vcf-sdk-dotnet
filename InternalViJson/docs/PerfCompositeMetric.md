# Vcenter.ViJson.OpenApi.Model.PerfCompositeMetric

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**PerfEntityMetricBase**](PerfEntityMetricBase.md) | The aggregated entity performance metrics.  If it exists, the *PerfSampleInfo* list of the aggregate entity is a complete list of *PerfSampleInfo* that could be contained in *PerfSampleInfo* lists of child entities.  | [optional] 
**ChildEntity** | [**List&lt;PerfEntityMetricBase&gt;**](PerfEntityMetricBase.md) | A list of *metrics* of performance providers that comprise the aggregated entity.  For example, Host is an aggregated entity for virtual machines and virtual machine Folders. ResourcePools are aggregate entities for virtual machines. Host, Folder, and Cluster are aggregate entities for hosts in the cluster or folder.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

