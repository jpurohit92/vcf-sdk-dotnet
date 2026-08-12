# Vcenter.ViJson.OpenApi.Model.ClusterIoFilterInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | IO Filter identifier.  | 
**Name** | **string** | Name of the IO Filter.  | 
**Vendor** | **string** | Vendor of the IO Filter.  | 
**VarVersion** | **string** | Version of the IO Filter.  | 
**Type** | **string** | Type of the IO Filter.  The set of possible values are listed in *IoFilterType_enum*. The property is unset if the information is not available.  | [optional] 
**Summary** | **string** | Short description of the IO Filter.  The property is unset if the information is not available.  | [optional] 
**ReleaseDate** | **string** | Release date of the IO Filter.  The property is unset if the information is not available.  | [optional] 
**OpType** | **string** | The operation that was performed for the IO Filter.  The set of possible values are described in *IoFilterOperation_enum*. If opType is *uninstall*, and the uninstallation of the filter was successful on all the hosts in the cluster, the filter will be removed from the cluster&#39;s filter list.  | 
**VibUrl** | **string** | The URL of the VIB package that the IO Filter is installed from.  The property is unset if the information is not available.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

