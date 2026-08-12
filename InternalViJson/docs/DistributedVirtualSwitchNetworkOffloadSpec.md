# Vcenter.ViJson.OpenApi.Model.DistributedVirtualSwitchNetworkOffloadSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifier of the specification.  | 
**Name** | **string** | Name of the specification.  | [optional] 
**Types** | **List&lt;string&gt;** | DPU types supported in the specification.  | [optional] 
**DpuCapability** | [**VMwareDvsDpuCapability**](VMwareDvsDpuCapability.md) | The *VMwareDvsDpuCapability* data object describes version-specific DPU capabilities.  If unset, the DPU capability should be determined from *VMwareDVSFeatureCapability.dpuCapability*.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

