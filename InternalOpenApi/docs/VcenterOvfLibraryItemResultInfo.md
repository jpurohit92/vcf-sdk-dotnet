# Vcenter.Automation.OpenApi.Model.VcenterOvfLibraryItemResultInfo
The Vcenter.Ovf.LibraryItem.ResultInfo schema defines the information returned along with the result of a create or deploy operation to describe errors, warnings, and informational messages produced by the server.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;VcenterOvfOvfError&gt;**](VcenterOvfOvfError.md) | Errors reported by the create or deploy operation. These errors would have prevented the create or deploy operation from completing successfully. | 
**Warnings** | [**List&lt;VcenterOvfOvfWarning&gt;**](VcenterOvfOvfWarning.md) | Warnings reported by the create or deploy operation. These warnings would not have prevented the create or deploy operation from completing successfully, but there might be issues that warrant attention. | 
**Information** | [**List&lt;VcenterOvfOvfInfo&gt;**](VcenterOvfOvfInfo.md) | Information messages reported by the create or deploy operation. For example, a non-required parameter was ignored. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

