# Vcenter.Automation.OpenApi.Model.VcenterTaggingCategoriesInfoCardinality
The Vcenter.Tagging.Categories.Info.Cardinality enumerated type defines the number of tags in a category that can be assigned to an object.  Possible values:   - `SINGLE`: An object can only be assigned one of the tags in this category. For example, if a category is \"Operating System\", then different tags of this category would be \"Windows\", \"Linux\", and so on. In this case a VM object can be assigned only one of these tags and hence the cardinality of the associated category here is single.   - `MULTIPLE`: An object can be assigned several of the tags in this category. For example, if a category is \"Server\", then different tags of this category would be \"AppServer\", \"DatabaseServer\" and so on. In this case a VM object can be assigned more than one of the above tags and hence the cardinality of the associated category here is multiple.   This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

