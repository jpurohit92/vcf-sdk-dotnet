# Vcenter.ViJson.OpenApi.Model.DpuStatusInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the physical element  | 
**Status** | [**ElementDescription**](ElementDescription.md) | The operational status of the physical element.  The status is one of the values specified in HostHardwareElementStatus.  See also *HostHardwareElementStatus_enum*.  | 
**DpuId** | **string** | Uniquely identify this DPU.  Should be the VMware identifier which can be composed from pci and other identifying elements.  | 
**Fru** | [**HostFru**](HostFru.md) | The FRU this sensor monitors, if any.  | [optional] 
**Sensors** | [**List&lt;DpuStatusInfoOperationalInfo&gt;**](DpuStatusInfoOperationalInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

