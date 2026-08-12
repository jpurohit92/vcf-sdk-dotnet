# Vcenter.ViJson.OpenApi.Model.DiskChangeInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartOffset** | **long** | Start offset (in bytes) of disk area described by this data structure.  | 
**Length** | **long** | Length (in bytes) of disk area described by this data structure.  | 
**ChangedArea** | [**List&lt;DiskChangeExtent&gt;**](DiskChangeExtent.md) | Modified disk areas.  Might be empty if no parts of the disk between startOffset and startOffset + length were modified.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

