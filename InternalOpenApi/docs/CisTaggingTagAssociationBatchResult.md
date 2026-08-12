# Vcenter.Automation.OpenApi.Model.CisTaggingTagAssociationBatchResult
The Cis.Tagging.TagAssociation.BatchResult schema describes the result of performing the same operation on several tags or objects in a single invocation.  This schema was added in __vSphere API 6.5__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | This is true if the batch operation completed without any errors. Otherwise it is false and all or some operations have failed.  This property was added in __vSphere API 6.5__. | 
**ErrorMessages** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | The list of error messages.  This property was added in __vSphere API 6.5__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

