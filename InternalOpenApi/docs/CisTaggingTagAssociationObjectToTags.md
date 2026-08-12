# Vcenter.Automation.OpenApi.Model.CisTaggingTagAssociationObjectToTags
The Cis.Tagging.TagAssociation.ObjectToTags schema describes an object and its related tags. Use the *POST /cis/tagging/tag-association?action=list-attached-tags-on-objects* operation to retrieve a list with each element containing an object and the tags attached to it.  This schema was added in __vSphere API 6.5__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | [**VapiStdDynamicID**](VapiStdDynamicID.md) | The identifier of the object.  This property was added in __vSphere API 6.5__. | 
**TagIds** | **List&lt;string&gt;** | The identifiers of the related tags.  This property was added in __vSphere API 6.5__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.cis.tagging.Tag&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.cis.tagging.Tag&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

