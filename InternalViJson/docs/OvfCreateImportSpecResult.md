# Vcenter.ViJson.OpenApi.Model.OvfCreateImportSpecResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ImportSpec** | [**ImportSpec**](ImportSpec.md) | The ImportSpec contains information about which *VirtualMachine*s and *VirtualApp*s are present in the entity and how they relate to each other.  | [optional] 
**FileItem** | [**List&lt;OvfFileItem&gt;**](OvfFileItem.md) | The files that must be uploaded by the caller as part of importing the entity.  The files must be uploaded in order, because some of them may be delta files that patch already-uploaded files.  | [optional] 
**Warning** | [**List&lt;MethodFault&gt;**](MethodFault.md) | Non-fatal warnings from the processing.  The ImportSpec will be valid, but the user may choose to reject it based on these warnings.  | [optional] 
**Error** | [**List&lt;MethodFault&gt;**](MethodFault.md) | Errors that happened during processing.  Something will be wrong with the ImportSpec, or it is not present.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

