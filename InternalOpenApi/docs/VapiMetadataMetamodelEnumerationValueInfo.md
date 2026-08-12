# Vcenter.Automation.OpenApi.Model.VapiMetadataMetamodelEnumerationValueInfo
The Vapi.Metadata.Metamodel.EnumerationValueInfo schema describes the enumeration value in the enumerated type.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** | Value in the enumerated type. All the characters in the string are capitalized. | 
**Metadata** | [**Dictionary&lt;string, VapiMetadataMetamodelElementMap&gt;**](VapiMetadataMetamodelElementMap.md) | Additional metadata for enumeration value in the enumerated type. The key in the map is the name of the metadata element and the value is the data associated with that metadata element.    The *Vapi.Metadata.Metamodel.MetadataIdentifier* contains possible string values for keys in the map. | 
**Documentation** | **string** | English language documentation for an enumeration value. It can contain HTML markup and documentation tags (similar to Javadoc tags). The first statement will be a noun or verb phrase that describes the purpose of the enumeration value. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

