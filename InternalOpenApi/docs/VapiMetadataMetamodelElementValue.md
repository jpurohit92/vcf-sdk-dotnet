# Vcenter.Automation.OpenApi.Model.VapiMetadataMetamodelElementValue
The Vapi.Metadata.Metamodel.ElementValue schema describes the value of the metadata element.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the value.  Possible values:   - &#x60;LONG&#x60;: Indicates the type of the value is a long (64 bit signed integer).   - &#x60;STRING&#x60;: Indicates the type of the value is a string (a variable length sequence of characters). The encoding is UTF-8.   - &#x60;STRING_LIST&#x60;: Indicates the type of the value is a list of strings.   - &#x60;STRUCTURE_REFERENCE&#x60;: Indicates the type of the value is an identifier for a structure element.   - &#x60;STRUCTURE_REFERENCE_LIST&#x60;: Indicates the type of the value is a list of identifiers for a structure element.   For more information see: *Vapi.Metadata.Metamodel.ElementValue.Type*. | 
**LongValue** | **long** | Long value of the metadata element.  This property is optional and it is only relevant when the value of type is *Vapi.Metadata.Metamodel.ElementValue.Type.LONG*. | [optional] 
**StringValue** | **string** | String value of the metadata element.  This property is optional and it is only relevant when the value of type is *Vapi.Metadata.Metamodel.ElementValue.Type.STRING*. | [optional] 
**ListValue** | **List&lt;string&gt;** | List of strings value of the metadata element.  This property is optional and it is only relevant when the value of type is *Vapi.Metadata.Metamodel.ElementValue.Type.STRING_LIST*. | [optional] 
**StructureId** | **string** | Identifier of the structure element.  This property is optional and it is only relevant when the value of type is *Vapi.Metadata.Metamodel.ElementValue.Type.STRUCTURE_REFERENCE*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vapi.structure&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vapi.structure&#x60;. | [optional] 
**StructureIds** | **List&lt;string&gt;** | List of identifiers of the structure elements.  This property is optional and it is only relevant when the value of type is *Vapi.Metadata.Metamodel.ElementValue.Type.STRUCTURE_REFERENCE_LIST*.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vapi.structure&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vapi.structure&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

