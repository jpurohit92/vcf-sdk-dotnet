# Vcenter.ViJson.OpenApi.Model.VsanVibSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Host onto which this VIB should be installed.  Refers instance of *HostSystem*.  | 
**MetaUrl** | **string** | URL to the metadata.zip file for this VIB.  If not provided, it is not possible to determine most of the VIB properties before installing it.  | [optional] 
**MetaSha1Sum** | **string** | SHA1 sum of the metadata file.  Must be provided if metaUrl field is provided.  | [optional] 
**VibUrl** | **string** | URL to the .vib file for this VIB.  | 
**VibSha1Sum** | **string** | SHA1 sum of the VIB file.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

