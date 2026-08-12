# Vcenter.Automation.OpenApi.Model.CisTaggingCategoryModel
The Cis.Tagging.CategoryModel schema defines a category that is used to group one or more tags.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the category.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Category&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Category&#x60;. | 
**Name** | **string** | The display name of the category. | 
**Description** | **string** | The description of the category. | 
**Cardinality** | **string** | The associated cardinality (Cardinality) of the category.  Possible values:   - &#x60;SINGLE&#x60;: An object can only be assigned one of the tags in this category. For example, if a category is \&quot;Operating System\&quot;, then different tags of this category would be \&quot;Windows\&quot;, \&quot;Linux\&quot;, and so on. In this case a VM object can be assigned only one of these tags and hence the cardinality of the associated category here is single.   - &#x60;MULTIPLE&#x60;: An object can be assigned several of the tags in this category. For example, if a category is \&quot;Server\&quot;, then different tags of this category would be \&quot;AppServer\&quot;, \&quot;DatabaseServer\&quot; and so on. In this case a VM object can be assigned more than one of the above tags and hence the cardinality of the associated category here is multiple.   For more information see: *Cis.Tagging.CategoryModel.Cardinality*. | 
**AssociableTypes** | **List&lt;string&gt;** | The types of objects that the tags in this category can be attached to. If the set is empty, then tags can be attached to all types of objects. This field works only for objects that reside in Inventory Service (IS). For non IS objects, this check is not performed today and hence a tag can be attached to any non IS object. | 
**UsedBy** | **List&lt;string&gt;** | The set of users that can use this category. To add users to this, you need to have the edit privilege on the category. Similarly, to unsubscribe from this category, you need the edit privilege on the category. You should not modify other users subscription from this set. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

