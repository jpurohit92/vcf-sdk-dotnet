# Vcenter.Automation.OpenApi.Model.VcenterHostHardwareDirectPathDevicesIterationSpec
The Vcenter.Host.Hardware.DirectPathDevices.IterationSpec schema contains properties used to break the result into pages when listing DirectPath devices in *GET /vcenter/host/{host}/hardware/direct-path-devices* operation.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PageSize** | **long** | The maximum number of entries to return in the result.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, then defaults to 256. | [optional] 
**Marker** | **string** | The {#member marker} is an opaque data structure that allows the caller to request the next page of results from #list operation.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, then the first page of results will be returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

