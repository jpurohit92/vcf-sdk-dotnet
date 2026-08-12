# Vcenter.ViJson.OpenApi.Model.VmfsUnmapBandwidthSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policy** | **string** | This property determines the unmap bandwidth policy.  See *HostVmfsVolumeUnmapBandwidthPolicy_enum* for supported values. If not specified, the default value is *fixed*, which means unmap is processed at a fixed rate.  | 
**FixedValue** | **long** | This property determines the bandwidth under the fixed policy.  | 
**DynamicMin** | **long** | This property determines the lower limits of the unmap bandwidth under the dynamic policy.  | 
**DynamicMax** | **long** | This property determines the upper limits of the unmap bandwidth under the dynamic policy.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

