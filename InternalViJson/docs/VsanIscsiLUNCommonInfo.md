# Vcenter.ViJson.OpenApi.Model.VsanIscsiLUNCommonInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LunId** | **int** | The optional ID of the LUN \\[0..255\\].  If not provided, next free identifier will be used. If provided, ID must be unique within target.  | [optional] 
**Alias** | **string** | An optional alias for LUN.  Can be used to indicate additional info about the LUN.  | [optional] 
**LunSize** | **long** | Size of the LUN object, unit is byte.  | 
**Status** | **string** | LUN status, the default value is &#39;Online&#39;.  See also *VsanIscsiLUNStatus_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

