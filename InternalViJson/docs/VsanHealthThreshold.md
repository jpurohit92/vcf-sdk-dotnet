# Vcenter.ViJson.OpenApi.Model.VsanHealthThreshold

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**YellowValue** | **long** | Entity beyond this threshold will be marked as VsanHealthStatusType.yellow.  | 
**RedValue** | **long** | Entity beyond this threshold will be marked as VsanHealthStatusType.red.  | 
**Target** | **string** | This optional attribute is used as the target for the thresholds.  The definition of the targets: *VsanHealthThresholdTarget_enum*  See also *VsanHealthThresholdTarget_enum*.  | [optional] 
**Enabled** | **bool** | As each target will have its own switch for threshold customization, this field is used to tell if the threshold takes effect.  If not given, the default value is False.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

