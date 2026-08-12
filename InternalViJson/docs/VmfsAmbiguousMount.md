# Vcenter.ViJson.OpenApi.Model.VmfsAmbiguousMount
An 'VmfsAmbiguousMount' fault occurs when ESX is unable to resolve the extents of a VMFS volume unambiguously.  This is thrown only when a VMFS volume has multiple extents and multiple copies of VMFS volumes are available. VMFS layer will not be able to determine how to re-construct the VMFS volume as multiple choices are available. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | Vmfs volume uuid  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

