# Vcenter.Automation.OpenApi.Model.VcenterTaggingAssociationsResultItem
Represents a tag that was attached to or detached from the resource object as part of the *PATCH /vcenter/tagging/associations* operation.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operation** | **string** | The type of operation that is performed on the tag.  Possible values:   - &#x60;ATTACH&#x60;: Attach the specified tag to the resource object. If a tag is already attached, the operation is idempotent and has no effect on that tag association.   - &#x60;DETACH&#x60;: Detach the specified tag from the resource object. If a tag is not attached, the operation is idempotent and has no effect on that tag association.   For more information see: *Vcenter.Tagging.Associations.Operation*.  This property was added in __vSphere API 9.1.0.0__. | 
**Tag** | **string** | The identifier of the tag involved in the operation.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Tag&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Tag&#x60;. | 
**TagCategoryNameInfo** | [**VcenterTaggingAssociationsTagCategoryNameInfo**](VcenterTaggingAssociationsTagCategoryNameInfo.md) | The name of the tag and the category it belongs to.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

