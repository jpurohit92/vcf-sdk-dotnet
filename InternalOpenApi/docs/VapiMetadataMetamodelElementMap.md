# Vcenter.Automation.OpenApi.Model.VapiMetadataMetamodelElementMap
The Vapi.Metadata.Metamodel.ElementMap schema contains the metadata elements.    One of the sources for metadata is the annotations present in the interface definition language. When an annotation is represented in the Vapi.Metadata.Metamodel.ElementMap, Vapi.Metadata.Metamodel.ElementMap describes the data specified in the arguments for the annotation.    For example, in `@UnionCase(tag=\"tag\", value=\"SELECT\")`, ElementMap describes the keyword arguments tag and value.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Elements** | [**Dictionary&lt;string, VapiMetadataMetamodelElementValue&gt;**](VapiMetadataMetamodelElementValue.md) | Metamodel information of the metadata elements. The key parameter of the map is the identifier for the element and the value corresponds to the element value. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

