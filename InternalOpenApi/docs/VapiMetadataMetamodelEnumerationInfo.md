# Vcenter.Automation.OpenApi.Model.VapiMetadataMetamodelEnumerationInfo
The Vapi.Metadata.Metamodel.EnumerationInfo schema contains the metamodel information of an enumeration element.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Dot separated name of the enumeration element. The segments in the name reflect the organization of the APIs. The format of each segment is lower case with underscores. Each underscore represents a word boundary. If there are acronyms in the word, the capitalization is preserved. This format makes it easy to translate the segment into a different naming convention. | 
**Values** | [**List&lt;VapiMetadataMetamodelEnumerationValueInfo&gt;**](VapiMetadataMetamodelEnumerationValueInfo.md) | Metamodel information of all the enumeration value elements contained in this enumeration element. The order of the enumeration value elements in the list is same as the order in which they are defined in the interface definition file. | 
**Metadata** | [**Dictionary&lt;string, VapiMetadataMetamodelElementMap&gt;**](VapiMetadataMetamodelElementMap.md) | Generic metadata elements for an enumeration element. The key in the map is the name of the metadata element and the value is the data associated with that metadata element.    The *Vapi.Metadata.Metamodel.MetadataIdentifier* contains possible string values for keys in the map. | 
**Documentation** | **string** | English language documentation for an enumeration element. It can contain HTML markup and Javadoc tags. The first sentence of the enumeration documentation is a complete sentence that identifies the enumeration by name and summarizes the purpose of the enumeration. The documentation describes the context in which the enumeration is used.    The documentation also contains references to the context in which the enumeration is used. But if the enumeration is used in many contexts, the references may not be present. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

