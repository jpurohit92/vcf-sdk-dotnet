# Vcenter.ViJson.OpenApi.Model.StorageArray

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name  | 
**Uuid** | **string** | Unique identifier  | 
**VendorId** | **string** | Storage array Vendor Id  | 
**ModelId** | **string** | Model Id  | 
**Firmware** | **string** | Storage array firmware  | [optional] 
**AlternateName** | **List&lt;string&gt;** | List of alternate storage array names  | [optional] 
**SupportedBlockInterface** | **List&lt;string&gt;** | Supported block-device interfaces  | [optional] 
**SupportedFileSystemInterface** | **List&lt;string&gt;** | Supported file-system interfaces  | [optional] 
**SupportedProfile** | **List&lt;string&gt;** | List of supported profiles  | [optional] 
**Priority** | **int** | Deprecated as of SMS API 6.0, replaced by *VasaProviderInfo.priority*.  Priority level of the provider for the given array within the session context.  SMS will use this value to pick a provider among the ones that are registered with SMS and manage this array. Once the provider is chosen, SMS will communicate with it to get the data related to this array. Valid range: 0 to 255.  | [optional] 
**DiscoverySvc** | [**List&lt;VASAStorageArrayDiscoverySvcInfo&gt;**](VASAStorageArrayDiscoverySvcInfo.md) | Required for NVMe-oF arrays and optional otherwise.  Transport information to address the array&#39;s discovery service.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

