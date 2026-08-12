# Vcenter.ViJson.OpenApi.Model.VsanVmdkLoadTestSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VmdkCreateSpec** | [**FileBackedVirtualDiskSpec**](FileBackedVirtualDiskSpec.md) | The VMDK creation spec.  This spec is only needed in preparing and cleaning up VMDK API.  | [optional] 
**VmdkIOSpec** | [**VsanVmdkIOLoadSpec**](VsanVmdkIOLoadSpec.md) | The VMDK IO test spec.  This spec is only needed in run VMDK load test API.  | [optional] 
**VmdkIOSpecSequence** | [**List&lt;VsanVmdkIOLoadSpec&gt;**](VsanVmdkIOLoadSpec.md) | The VMDK IO test spec.  The tests specified will be run in the order given. This spec is only needed in run VMDK load test API. If set, vmdkIOSpec will be ignored.  | [optional] 
**StepDurationSec** | **long** | Only relevant when vmdkIOSpecSequence is used.  Represents the time after which the next IO spec in the sequence will be used.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

