# Vcenter.ViJson.OpenApi.Model.VsanIODiagnosticsTarget

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of the target to run IO diagnostics against.  See also *VsanIODiagnosticsTargetType_enum*.  | 
**EntityId** | **string** | The entity id of the target to run IO diagnostics against.  For virtual machine, the field is VM moRef.  | 
**ObjUuids** | **List&lt;string&gt;** | The vSAN object uuids involved to run IO diagnostics.  If not specified, it will list all the backing objects for the entity with the specified type and entityId.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

