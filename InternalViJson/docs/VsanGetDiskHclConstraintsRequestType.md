# Vcenter.ViJson.OpenApi.Model.VsanGetDiskHclConstraintsRequestType
The parameters of *VsanVcClusterHealthSystem.VsanGetDiskHclConstraints*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Release** | **string** | The target vSphere release. If not provided, HCL constraints for all the supported releases will be returned.  | [optional] 
**DiskModels** | [**List&lt;VsanDiskModelInfo&gt;**](VsanDiskModelInfo.md) | The disk models to query. If provided, the HCL constraints with matching disk model info as in the query options will be returned.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

