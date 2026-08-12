# Vcenter.ViJson.OpenApi.Model.CnsVSANFileCreateSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SoftQuotaInMb** | **long** | During creation this field specifies desired soft quota for file volume in MB.  When an existing file share is specified then this field will be ignored.  | [optional] 
**Permission** | [**List&lt;VsanFileShareNetPermission&gt;**](VsanFileShareNetPermission.md) | The permission parameters set for this file share.  If this field is not set, then no user can access this file share.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

