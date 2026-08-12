# Vcenter.ViJson.OpenApi.Model.NvdimmDimmInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DimmHandle** | **int** | Unique device identifier  | 
**HealthInfo** | [**NvdimmHealthInfo**](NvdimmHealthInfo.md) | Health status of nvdimm.  *NvdimmHealthInfo*  | 
**TotalCapacity** | **long** | Total capacity of NVDIMM in bytes  | 
**PersistentCapacity** | **long** | Total persistent capacity in DIMM (in bytes)  | 
**AvailablePersistentCapacity** | **long** | Persistent Capacity in DIMM currently not allocated  | 
**VolatileCapacity** | **long** | Total volatile capacity in DIMM (in bytes)  | 
**AvailableVolatileCapacity** | **long** | Volatile capacity in DIMM currently not allocated  | 
**BlockCapacity** | **long** | Total block capacity in DIMM (in bytes)  | 
**RegionInfo** | [**List&lt;NvdimmRegionInfo&gt;**](NvdimmRegionInfo.md) | NVDIMM region information.  List of regions in the NVDIMM. These regions may or maynot be a part of an interleave set.  | [optional] 
**RepresentationString** | **string** | NVDIMM Representation string which is a sequence of numbers to uniquely identify the DIMM.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

