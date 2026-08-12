# Vcenter.Automation.OpenApi.Model.VapiMetadataMetamodelOperationInfo
The Vapi.Metadata.Metamodel.OperationInfo schema contains metamodel information of an operation element.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the operation element in a canonical format. The format is lower case with underscores. Each underscore represents a word boundary. If there are acronyms in the word, the capitalization is preserved. This format makes it easy to translate the segment into a different naming convention. | 
**Params** | [**List&lt;VapiMetadataMetamodelFieldInfo&gt;**](VapiMetadataMetamodelFieldInfo.md) | Metamodel information for the parameter elements. The order of the parameters elements in the list is same as the order of the parameters declared in the interface definition file. | 
**Output** | [**VapiMetadataMetamodelOperationResultInfo**](VapiMetadataMetamodelOperationResultInfo.md) | Metamodel type for the output element. | 
**Errors** | [**List&lt;VapiMetadataMetamodelErrorInfo&gt;**](VapiMetadataMetamodelErrorInfo.md) | List of error elements that might be reported by the operation element. If the operation reports the same error for more than one reason, the list contains the error element associated with the error more than once with different documentation elements. | 
**Metadata** | [**Dictionary&lt;string, VapiMetadataMetamodelElementMap&gt;**](VapiMetadataMetamodelElementMap.md) | Generic metadata elements for the operation element. The key in the map is the name of the metadata element and the value is the data associated with that metadata element.    The *Vapi.Metadata.Metamodel.MetadataIdentifier* contains possible string values for key in the map. | 
**Documentation** | **string** | English language documentation for the operation element. It can contain HTML markup and Javadoc tags. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

