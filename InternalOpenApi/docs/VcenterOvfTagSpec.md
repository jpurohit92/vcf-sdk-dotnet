# Vcenter.Automation.OpenApi.Model.VcenterOvfTagSpec
The Vcenter.Ovf.TagSpec schema specifies information required to attach a tag while deploying a VM.    Represents a tag specification with optional *Cis.Tagging.Tag* and/or *Vcenter.Ovf.TagNameSpec*. The *Cis.Tagging.Tag* should already exist in vSphere, otherwise VM deployment will fail.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TagId** | **string** | The tag identifier of a vSphere tag. If this field is specified in addition to *Vcenter.Ovf.TagSpec.tag_name_spec*, then both tagId and *Vcenter.Ovf.TagSpec.tag_name_spec* must belong to the same vSphere tag.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, then *Vcenter.Ovf.TagSpec.tag_name_spec* must be specified. | [optional] 
**TagNameSpec** | [**VcenterOvfTagNameSpec**](VcenterOvfTagNameSpec.md) | Name of the tag with associated category. If this field is specified in addition to *Vcenter.Ovf.TagSpec.tag_id*, then both *Vcenter.Ovf.TagSpec.tag_id* and tagNameSpec must belong to the same vSphere tag.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, then *Vcenter.Ovf.TagSpec.tag_id* must be specified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

