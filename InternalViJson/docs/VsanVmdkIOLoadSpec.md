# Vcenter.ViJson.OpenApi.Model.VsanVmdkIOLoadSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReadPct** | **int** | The read ratio in the IO workload.  It&#39;s used to specifies the fraction of the read IOs over the total number of IOs generated. It should be in the range of 0 to 100.  | 
**Oio** | **int** | The number of outstanding IO.  It&#39;s used to specify how many outstanding IO should be issued in the IO workload.  | 
**IosizeB** | **int** | The average IO size in byte.  It&#39;s used to specify the IO size for the read/write request in the IO workload.  | 
**DataSizeMb** | **long** | The size of the portion of the virtual disk covered by the IO workload test.  | 
**Random** | **bool** | True to specify the random IO access pattern in IO workload test.  | 
**StartOffsetB** | **long** | The start offset in byte for the virtual disk to run the IO workload test.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

