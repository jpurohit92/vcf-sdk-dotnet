# Vcenter.ViJson.OpenApi.Model.VirtualMachineFileLayoutExFileInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | Key to reference this file.  | 
**Name** | **string** | Name of the file, including the complete datastore path.  | 
**Type** | **string** | Type of the file.  *VirtualMachineFileLayoutExFileType_enum* lists all valid values.  | 
**Size** | **long** | Size of the file in bytes.  | 
**UniqueSize** | **long** | Size of the file in bytes corresponding to the file blocks that were allocated uniquely.  In other words, if the underlying storage supports sharing of file blocks across disk files, the property corresponds to the size of the file blocks that were allocated only in context of this file, i.e. it does not include shared blocks that were allocated in other files. This property will be unset if the underlying implementation is unable to compute this information. One example of this is when the file resides on a NAS datastore whose underlying storage doesn&#39;t support this metric. In some cases the field might be set but the value could be over-estimated due to the inability of the NAS based storage to provide an accurate value.  | [optional] 
**BackingObjectId** | **string** | Backing object&#39;s durable and unmutable identifier.  Each backing object has a unique identifier which is not settable. This property is applied to the file backed by a storage object, such as vvol.  | [optional] 
**Accessible** | **bool** | Flag which indicates the accessibility of the file when the file info object was created.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

