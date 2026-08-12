# Vcenter.ViJson.OpenApi.Model.NvdimmInterleaveSetInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SetId** | **int** | Unique set ID  | 
**RangeType** | **string** | Volatile or persistent interleave set.  Must be one of the values of *NvdimmRangeType_enum*  | 
**BaseAddress** | **long** | Start address of range  | 
**Size** | **long** | Length of range in bytes  | 
**AvailableSize** | **long** | Capacity currently not allocated to namespace in bytes  | 
**DeviceList** | **List&lt;int&gt;** | List of nvdimms contributing to this interleave set  | [optional] 
**State** | **string** | State of interleave set.  Must be one of the values in *NvdimmInterleaveSetState_enum*  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

