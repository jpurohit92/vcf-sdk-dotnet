# Vcenter.ViJson.OpenApi.Model.VmfsConfigOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlockSizeOption** | **int** | Supported values of VMFS block size in kilobytes (KB) *HostVmfsVolume.blockSize*.  | 
**UnmapGranularityOption** | **List&lt;int&gt;** | Supported values of VMFS unmap granularity *HostVmfsVolume.unmapGranularity*.  The unit is KB.  | [optional] 
**UnmapBandwidthFixedValue** | [**LongOption**](LongOption.md) | Fixed unmap bandwidth min/max/default value  | [optional] 
**UnmapBandwidthDynamicMin** | [**LongOption**](LongOption.md) | Dynamic unmap bandwidth lower limit min/max/default value.  | [optional] 
**UnmapBandwidthDynamicMax** | [**LongOption**](LongOption.md) | Dynamic unmap bandwitdth upper limit min/max/default value.  | [optional] 
**UnmapBandwidthIncrement** | **long** | Increment value of unmap bandwidth  | [optional] 
**UnmapBandwidthUltraLow** | **long** | Fixed unmap bandwidth ultra low limit value in MB/sec.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

