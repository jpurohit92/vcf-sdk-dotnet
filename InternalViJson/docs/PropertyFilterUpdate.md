# Vcenter.ViJson.OpenApi.Model.PropertyFilterUpdate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Filter** | [**ManagedObjectReference**](ManagedObjectReference.md) | Filter that was updated.  Refers instance of *PropertyFilter*.  | 
**ObjectSet** | [**List&lt;ObjectUpdate&gt;**](ObjectUpdate.md) | Set of changes to object properties in the filter.  | [optional] 
**MissingSet** | [**List&lt;MissingObject&gt;**](MissingObject.md) | Objects that could not be found on the server, but were specified in a *PropertyFilterSpec.objectSet*.  This field will only be populated for objects that were determined to be missing since the data version passed to *PropertyCollector.CheckForUpdates*, *PropertyCollector.WaitForUpdates*, or *PropertyCollector.WaitForUpdatesEx* and will not contain objects that were missing prior to that data version.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

