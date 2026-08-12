# Vcenter.ViJson.OpenApi.Model.VsanSmartParameter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Parameter** | **string** | S.M.A.R.T.  parameter ID. Unset if the parameter is not supported. See all supported parameter ID in *VsanSmartParameterType_enum*  See also *VsanSmartParameterType_enum*.  | [optional] 
**Value** | **int** | The raw value reported by the disk.  Unset if the value is not available. Specially, for \&quot;smarthealthstatus\&quot; parameter, the value is represented as: 0 represents for \&quot;OK\&quot;. 1 represents for \&quot;Warning\&quot;. 2 represents for \&quot;Impending Failure\&quot;. 3 represents for \&quot;Unknown\&quot;. Other values for \&quot;smarthealthstatus\&quot; parameter are invalid.  | [optional] 
**Threshold** | **int** | The (failure) limit for the parameter.  Unset if the value is not available.  | [optional] 
**Worst** | **int** | The highest value ever recorded for the parameter.  Unset if the value is not available.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

