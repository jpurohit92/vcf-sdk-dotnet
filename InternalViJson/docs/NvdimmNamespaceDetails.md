# Vcenter.ViJson.OpenApi.Model.NvdimmNamespaceDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | Universally unique identifier assigned to namespace in string format  | 
**FriendlyName** | **string** | Human readable name of namespace  | 
**Size** | **long** | Size of namespace in bytes.  | 
**Type** | **string** | Type of the namespace to be created - block or persistent.  Must be one of the values in *NvdimmNamespaceType_enum*  | 
**NamespaceHealthStatus** | **string** | Health status of DIMM(s) part of the namespace.  Must be one of the values of *NvdimmNamespaceDetailsHealthStatus_enum*  | 
**InterleavesetID** | **int** | The interleave set ID of the namespace.  | 
**State** | **string** | State of namespace.  Must be one of *NvdimmNamespaceDetailsState_enum*  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

