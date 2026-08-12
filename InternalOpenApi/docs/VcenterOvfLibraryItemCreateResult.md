# Vcenter.Automation.OpenApi.Model.VcenterOvfLibraryItemCreateResult
The Vcenter.Ovf.LibraryItem.CreateResult schema defines the result of the create operation. See *POST /vcenter/ovf/library-item*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Succeeded** | **bool** | Whether the create operation completed successfully. | 
**OvfLibraryItemId** | **string** | Identifier of the created or updated library item.  If missing or &#x60;null&#x60;, the create operation failed and *Vcenter.Ovf.LibraryItem.CreateResult.error* will describe the error(s) that caused the failure.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.library.Item&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.library.Item&#x60;. | [optional] 
**Error** | [**VcenterOvfLibraryItemResultInfo**](VcenterOvfLibraryItemResultInfo.md) | Errors, warnings, and informational messages produced by the create operation.  If missing or &#x60;null&#x60;, no errors, warnings, or informational messages were reported by the create operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

