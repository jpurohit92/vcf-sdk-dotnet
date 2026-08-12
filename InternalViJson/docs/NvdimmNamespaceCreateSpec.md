# Vcenter.ViJson.OpenApi.Model.NvdimmNamespaceCreateSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FriendlyName** | **string** | Friendly name of the namespace to be created.  A friendly name can be provided by user to associate a name to the created namespace, but such a name is not mandatory and is empty string by default.  | [optional] 
**BlockSize** | **long** | Size of block in the namespace.  For persistent region type, block size is one. For block region, block size represents one of the logical block sizes of 512, 4096 etc.  | 
**BlockCount** | **long** | Number of blocks in the namespace.  For persistent region type, blockCount is the size of persistent region in bytes. For block region type, block count represent number of bytes per block size.  | 
**Type** | **string** | Type of the namespace to be created - block or persistent.  Must be one of the values in *NvdimmNamespaceType_enum*  | 
**LocationID** | **int** | This identifier is the interleave set ID if the namespace is being used in persistent mode.  If in block mode, this is a device handle.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

