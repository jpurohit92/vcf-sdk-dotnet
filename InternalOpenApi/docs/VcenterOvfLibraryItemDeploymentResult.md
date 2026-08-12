# Vcenter.Automation.OpenApi.Model.VcenterOvfLibraryItemDeploymentResult
The Vcenter.Ovf.LibraryItem.DeploymentResult schema defines the result of the deploy operation. See *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=deploy*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Succeeded** | **bool** | Whether the deploy operation completed successfully. | 
**ResourceId** | [**VcenterOvfLibraryItemDeployableIdentity**](VcenterOvfLibraryItemDeployableIdentity.md) | Identifier of the deployed resource entity.  If missing or &#x60;null&#x60;, the deploy operation failed and *Vcenter.Ovf.LibraryItem.DeploymentResult.error* will describe the error(s) that caused the failure. | [optional] 
**Error** | [**VcenterOvfLibraryItemResultInfo**](VcenterOvfLibraryItemResultInfo.md) | Errors, warnings, and informational messages produced by the deploy operation.  If missing or &#x60;null&#x60;, no errors, warnings, or informational messages were reported by the deploy operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

