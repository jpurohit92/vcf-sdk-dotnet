# Vcenter.Automation.OpenApi.Model.ContentLibrarySubscriptionsCreateSpecNewSubscribedLibrary
The Content.Library.Subscriptions.CreateSpecNewSubscribedLibrary schema defines the information required to create a new subscribed library.  This schema was added in __vSphere API 6.7.2__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the subscribed library.  This property was added in __vSphere API 6.7.2__. | 
**Description** | **string** | Description of the subscribed library.  This property was added in __vSphere API 6.7.2__.  If missing or &#x60;null&#x60;, the description will be an empty string. | [optional] 
**StorageBackings** | [**List&lt;ContentLibraryStorageBacking&gt;**](ContentLibraryStorageBacking.md) | The list of default storage backings for this library.    The list must contain exactly one storage backing. Multiple default storage locations are not currently supported but may become supported in future releases.  This property was added in __vSphere API 6.7.2__. | 
**AutomaticSyncEnabled** | **bool** | Specifies whether the library should participate in automatic library synchronization.  This property was added in __vSphere API 6.7.2__. | 
**OnDemand** | **bool** | Specifies whether a library item&#39;s content will be synchronized only on demand.  This property was added in __vSphere API 6.7.2__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

