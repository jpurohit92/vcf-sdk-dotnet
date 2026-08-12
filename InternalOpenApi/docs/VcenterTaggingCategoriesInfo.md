# Vcenter.Automation.OpenApi.Model.VcenterTaggingCategoriesInfo
The Vcenter.Tagging.Categories.Info schema contains the category Name  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the category.  This property was added in __vSphere API 9.0.0.0__. | 
**Description** | **string** | The description of the category.  This property was added in __vSphere API 9.0.0.0__. | 
**Cardinality** | **string** | The associated cardinality (Cardinality) of the category.  Possible values:   - &#x60;SINGLE&#x60;: An object can only be assigned one of the tags in this category. For example, if a category is \&quot;Operating System\&quot;, then different tags of this category would be \&quot;Windows\&quot;, \&quot;Linux\&quot;, and so on. In this case a VM object can be assigned only one of these tags and hence the cardinality of the associated category here is single.   - &#x60;MULTIPLE&#x60;: An object can be assigned several of the tags in this category. For example, if a category is \&quot;Server\&quot;, then different tags of this category would be \&quot;AppServer\&quot;, \&quot;DatabaseServer\&quot; and so on. In this case a VM object can be assigned more than one of the above tags and hence the cardinality of the associated category here is multiple.   For more information see: *Vcenter.Tagging.Categories.Info.Cardinality*.  This property was added in __vSphere API 9.0.0.0__. | 
**AssociableTypes** | **List&lt;string&gt;** | The types of objects that the tags in this category can be attached to. If the set is empty, then tags can be attached to all types of objects.  This property was added in __vSphere API 9.0.0.0__. | 
**UsedBy** | **List&lt;string&gt;** | The set of users that can use this category.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

