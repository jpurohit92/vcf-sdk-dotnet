# Vcenter.ViJson.OpenApi.Model.NvdimmNamespaceInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | Universally unique identifier assigned to namespace in string format  | 
**FriendlyName** | **string** | Friendly name of namespace  | 
**BlockSize** | **long** | Size of logical block size.  For persistent region type, block size is one. For block region, block size represents one of the logical block sizes of 512, 4096 etc.  | 
**BlockCount** | **long** | Number of blocks in the namespace.  For persistent region type, blockCount is the size of persistent region in bytes. For block region type, block count represent number of bytes per block size.  | 
**Type** | **string** | Type of the namespace to be created - block or persistent.  Must be one of the values in *NvdimmNamespaceType_enum*  | 
**NamespaceHealthStatus** | **string** | Health status of DIMM(s) part of the namespace.  Must be one of the values of *NvdimmNamespaceHealthStatus_enum*  | 
**LocationID** | **int** | This identifier is the interleave set ID if this namespace is being used in persistent mode.  If in block mode, this is a nvdimm device handle.  | 
**State** | **string** | State of namespace.  Must be one of *NvdimmNamespaceState_enum*  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

