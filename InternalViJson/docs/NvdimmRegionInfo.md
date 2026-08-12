# Vcenter.ViJson.OpenApi.Model.NvdimmRegionInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RegionId** | **int** | NVDIMM region ID  | 
**SetId** | **int** | Interleave set ID.  Interleave set to which this region belongs. A value of 0 indicates that this region is not a part of any interleave set.  | 
**RangeType** | **string** | Type of region.  Must be one of the values of *NvdimmRangeType_enum*  | 
**StartAddr** | **long** | Region start address.  This represents the address within the NVDIMM to which this NVDIMM region belongs (Dimm physical address). If *NvdimmRegionInfo.setId* is 0, this field is not valid.  | 
**Size** | **long** | Size of region in bytes.  If this region is part of interleave set (represented by non zero *NvdimmRegionInfo.setId*) and the region is interleaved across multiple dimms (represented by more that one element in *NvdimmInterleaveSetInfo.deviceList* for associated set id *NvdimmRegionInfo.setId*), this size represents part of the interleave set size - (total interleave set size / number of dimms in *NvdimmInterleaveSetInfo.deviceList*). Example: If Interleave set with set id 5, has a size of 2TB and has 2 NVDIMMs contributing to it (size of *NvdimmInterleaveSetInfo.deviceList* is 2), then this size parameter is 2TB/2 &#x3D; 1TB. If *NvdimmRegionInfo.setId* is 0, this field is not valid.  | 
**Offset** | **long** | Offset of nvdimm within interleave set.  This represents offset with respect to base address in *NvdimmInterleaveSetInfo.baseAddress*. If *NvdimmRegionInfo.setId* is 0, this field is not valid.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

