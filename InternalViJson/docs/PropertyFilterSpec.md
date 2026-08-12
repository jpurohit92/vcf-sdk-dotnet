# Vcenter.ViJson.OpenApi.Model.PropertyFilterSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropSet** | [**List&lt;PropertySpec&gt;**](PropertySpec.md) | Set of properties to include in the filter, specified for each object type.  | 
**ObjectSet** | [**List&lt;ObjectSpec&gt;**](ObjectSpec.md) | Set of specifications that determine the objects to filter.  | 
**ReportMissingObjectsInResults** | **bool** | Control how to report missing objects during filter creation.  If false or unset and *PropertyFilterSpec.objectSet* refers to missing objects, filter creation will fail with a *ManagedObjectNotFound* fault.  If true and *PropertyFilterSpec.objectSet* refers to missing objects, filter creation will not fail and missing objects will be reported via filter results. This is the recommended setting when *PropertyFilterSpec.objectSet* refers to transient objects.  In an *UpdateSet* missing objects will appear in the *PropertyFilterUpdate.missingSet* field.  In a *RetrieveResult* missing objects will simply be omitted from the objects field.  For a call to *PropertyCollector.RetrieveProperties* missing objects will simply be omitted from the results.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

