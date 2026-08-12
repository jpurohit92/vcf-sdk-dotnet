# Vcenter.Automation.OpenApi.Model.ContentLibraryMigrateSpec
The Content.Library.MigrateSpec schema defines target storage backing library to migrate the library content to.    This is used for local, published and subscribed content libraries.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StorageBackings** | [**List&lt;ContentLibraryStorageBacking&gt;**](ContentLibraryStorageBacking.md) | This value can be used to set the *Content.LibraryModel.storage_backings* property as the storage backing target to migrate the library to.    Multiple default storage locations are not currently supported but may become supported in future releases.    VCF 9.1 Migration of library with {StorageBacking.Type#STORAGEPOLICY} as storage backing type to a different storage policy or {StorageBacking.Type#DATASTORE} is not supported.    This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

