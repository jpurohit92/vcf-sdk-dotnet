# Vcenter.ViJson.OpenApi.Model.VsanObjIdentityQuerySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KnownSpbmProfileUuids** | **List&lt;string&gt;** | The UUID list for the known SPBM profile(s) on VC.  This field is specific for host API. It will be ignored when provided to VC API call. If this field is set, *VsanObjectSystem.VsanQueryObjectIdentities* will not return SPBM profile name to caller to save the memory consumption.  | [optional] 
**IncludeEffectiveCapacity** | **bool** | The flag determines if effective capacity attributes need to be included.  The effective capacity attributes will not be included in the result if this field is unset.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

