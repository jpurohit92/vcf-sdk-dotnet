# Vcenter.Automation.OpenApi.Model.VapiMetadataMetamodelFieldInfo
The Vapi.Metadata.Metamodel.FieldInfo schema contains metamodel information of a field element contained in a structure element.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the field element in a canonical format. The format is lower case with underscores. Each underscore represents a word boundary. If there are acronyms in the word, the capitalization is preserved. This format makes it easy to translate the segment into a different naming convention. | 
**Type** | [**VapiMetadataMetamodelType**](VapiMetadataMetamodelType.md) | Type information. | 
**Metadata** | [**Dictionary&lt;string, VapiMetadataMetamodelElementMap&gt;**](VapiMetadataMetamodelElementMap.md) | Generic metadata elements for the field element. The key in the map is the name of the metadata element and the value is the data associated with that metadata element.    The *Vapi.Metadata.Metamodel.MetadataIdentifier* contains possible string values for keys in the map. | 
**Documentation** | **string** | English language documentation for the field element. It can contain HTML markup and Javadoc tags. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

