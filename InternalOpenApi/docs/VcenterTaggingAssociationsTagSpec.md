# Vcenter.Automation.OpenApi.Model.VcenterTaggingAssociationsTagSpec
Represents a tag specification for an operation to be performed with optional *Cis.Tagging.Tag* and/or *Vcenter.Tagging.Associations.TagCategoryNameInfo*.    At least one of *Cis.Tagging.Tag* or *Vcenter.Tagging.Associations.TagCategoryNameInfo* should be provided. If both are specified, *Vcenter.Tagging.Associations.TagCategoryNameInfo* must refer to the same *Cis.Tagging.Tag*. If *Cis.Tagging.Tag* and *Vcenter.Tagging.Associations.TagCategoryNameInfo* are missing or `null`, the update operation will throw an *Vapi.Std.Errors.InvalidArgument*.   This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operation** | **string** | The desired operation that will be applied to the resource.  Possible values:   - &#x60;ATTACH&#x60;: Attach the specified tag to the resource object. If a tag is already attached, the operation is idempotent and has no effect on that tag association.   - &#x60;DETACH&#x60;: Detach the specified tag from the resource object. If a tag is not attached, the operation is idempotent and has no effect on that tag association.   For more information see: *Vcenter.Tagging.Associations.Operation*.  This property was added in __vSphere API 9.1.0.0__. | 
**TagId** | **string** | This property was added in __vSphere API 9.1.0.0__.  Tag identifier involved.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Tag&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.tagging.Tag&#x60;. | [optional] 
**TagCategoryNameInfo** | [**VcenterTaggingAssociationsTagCategoryNameInfo**](VcenterTaggingAssociationsTagCategoryNameInfo.md) | This property was added in __vSphere API 9.1.0.0__.  Tag by name and category involved. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

