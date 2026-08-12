# Vcenter.Automation.OpenApi.Model.CisTaggingTagAssociationTagToObjects
The Cis.Tagging.TagAssociation.TagToObjects schema describes a tag and its related objects. Use the *POST /cis/tagging/tag-association?action=list-attached-objects-on-tags* operation to retrieve a list with each element containing a tag and the objects to which it is attached.  This schema was added in __vSphere API 6.5__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TagId** | **string** | The identifier of the tag.  This property was added in __vSphere API 6.5__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Tag&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Tag&#x60;. | 
**ObjectIds** | [**List&lt;VapiStdDynamicID&gt;**](VapiStdDynamicID.md) | The identifiers of the related objects.  This property was added in __vSphere API 6.5__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

