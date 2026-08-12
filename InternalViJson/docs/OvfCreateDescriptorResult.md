# Vcenter.ViJson.OpenApi.Model.OvfCreateDescriptorResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OvfDescriptor** | **string** | The OVF descriptor for the entity.  | 
**Error** | [**List&lt;MethodFault&gt;**](MethodFault.md) | Errors that happened during processing.  For example, unknown or unsupported devices could be found (in which case this array will contain one or more instances of Unsupported-/UnknownDevice).  | [optional] 
**Warning** | [**List&lt;MethodFault&gt;**](MethodFault.md) | Non-fatal warnings from the processing.  The result will be valid, but the user may choose to reject it based on these warnings.  | [optional] 
**IncludeImageFiles** | **bool** | Returns true if there are ISO or Floppy images attached to one or more VMs.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

