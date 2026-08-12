# Vcenter.ViJson.OpenApi.Model.VsanComponentBasicInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | Component UUID.  | 
**ComponentState** | **string** | Component state.  This variable will be one of the enums pre-defined in *VsanComponentStateTypes*.  | 
**HostName** | **string** | Owner host name.  | 
**HostNodeUuid** | **string** | Owner host node UUID.  | 
**FaultDomainUuid** | **string** | Fault domain UUID.  Used when the component is in a stretched cluster.  | [optional] 
**FaultDomainName** | **string** | Fault domain name.  Used when the component is in a stretched cluster.  | [optional] 
**CacheDiskInfo** | [**DiskInfo**](DiskInfo.md) | Cache disk information.  Used when the component is in vSAN OSA environment.  | [optional] 
**CapacityDiskInfo** | [**DiskInfo**](DiskInfo.md) | Capacity disk information.  Supported for both vSAN OSA and ESA environment. Unset if the component is in abnormal state like &#39;stale&#39; or &#39;absent&#39;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

