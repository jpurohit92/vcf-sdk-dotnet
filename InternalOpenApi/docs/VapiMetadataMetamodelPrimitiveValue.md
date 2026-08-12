# Vcenter.Automation.OpenApi.Model.VapiMetadataMetamodelPrimitiveValue
The Vapi.Metadata.Metamodel.PrimitiveValue schema contains value of the constant element.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the constant value.  Possible values:   - &#x60;BOOLEAN&#x60;: Indicates the value is a boolean (true or false).   - &#x60;DOUBLE&#x60;: Indicates the value is a double (64 bit floating number).   - &#x60;LONG&#x60;: Indicates the value is a long (64 bit signed integer).   - &#x60;STRING&#x60;: Indicates the value is a string (a variable length sequence of characters). The encoding is UTF8.   For more information see: *Vapi.Metadata.Metamodel.PrimitiveValue.Type*. | 
**BooleanValue** | **bool** | Boolean value of the constant.  This property is optional and it is only relevant when the value of type is *Vapi.Metadata.Metamodel.PrimitiveValue.Type.BOOLEAN*. | [optional] 
**DoubleValue** | **double** | Double value of the constant.  This property is optional and it is only relevant when the value of type is *Vapi.Metadata.Metamodel.PrimitiveValue.Type.DOUBLE*. | [optional] 
**LongValue** | **long** | Long value of the constant.  This property is optional and it is only relevant when the value of type is *Vapi.Metadata.Metamodel.PrimitiveValue.Type.LONG*. | [optional] 
**StringValue** | **string** | String value of the constant.  This property is optional and it is only relevant when the value of type is *Vapi.Metadata.Metamodel.PrimitiveValue.Type.STRING*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

