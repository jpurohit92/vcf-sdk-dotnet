# Vcenter.Automation.OpenApi.Model.VapiMetadataMetamodelConstantValue
The Vapi.Metadata.Metamodel.ConstantValue schema contains the metamodel information of the constant element.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Category** | **string** | Category of the type of constant value.  Possible values:   - &#x60;PRIMITIVE&#x60;: Indicates the type of constant value is primitive.   - &#x60;LIST&#x60;: Indicates the type of constant value is a list.   For more information see: *Vapi.Metadata.Metamodel.ConstantValue.Category*. | 
**PrimitiveValue** | [**VapiMetadataMetamodelPrimitiveValue**](VapiMetadataMetamodelPrimitiveValue.md) | Primitive value of the constant element.  This property is optional and it is only relevant when the value of category is *Vapi.Metadata.Metamodel.ConstantValue.Category.PRIMITIVE*. | [optional] 
**ListValue** | [**List&lt;VapiMetadataMetamodelPrimitiveValue&gt;**](VapiMetadataMetamodelPrimitiveValue.md) | List value of the constant element.  This property is optional and it is only relevant when the value of category is *Vapi.Metadata.Metamodel.ConstantValue.Category.LIST*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

