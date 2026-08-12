# Vcenter.ViJson.OpenApi.Model.VsanIscsiLUNSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LunId** | **int** | The optional ID of the LUN \\[0..255\\].  If not provided, next free identifier will be used. If provided, ID must be unique within target.  | [optional] 
**Alias** | **string** | An optional alias for LUN.  Can be used to indicate additional info about the LUN.  | [optional] 
**LunSize** | **long** | Size of the LUN object, unit is byte.  | 
**Status** | **string** | LUN status, the default value is &#39;Online&#39;.  See also *VsanIscsiLUNStatus_enum*.  | [optional] 
**StoragePolicy** | [**VirtualMachineProfileSpec**](VirtualMachineProfileSpec.md) | Storage policy used by this LUN, if not set when create LUN, the default one defined in iSCSI service will be used.  | [optional] 
**NewLunId** | **int** | The new ID of the LUN \\[0..255\\].  If provided, ID must be unique within target.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

