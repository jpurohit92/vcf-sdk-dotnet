# Vcenter.Automation.OpenApi.Model.VapiMetadataMetamodelComponentInfo
The Vapi.Metadata.Metamodel.ComponentInfo schema contains metamodel metadata information about a component element.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Dot separated name of the component element. The segments in the name reflect the organization of the APIs. The format of each segment is lower case with underscores. Each underscore represents a word boundary. If there are acronyms in the word, the capitalization is preserved. This format makes it easy to translate the segment into a different naming convention. | 
**Packages** | [**Dictionary&lt;string, VapiMetadataMetamodelPackageInfo&gt;**](VapiMetadataMetamodelPackageInfo.md) | Metamodel metadata information of all the package elements contained in the component element. The key in the map is the identifier of the package element and the value in the map is the metamodel information of the package element.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.vapi.package&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.vapi.package&#x60;. | 
**Metadata** | [**Dictionary&lt;string, VapiMetadataMetamodelElementMap&gt;**](VapiMetadataMetamodelElementMap.md) | Generic metadata for the component element. The key in the map is the name of the metadata element and the value is the data associated with that metadata element.    The *Vapi.Metadata.Metamodel.MetadataIdentifier* contains possible string values for keys in the map. | 
**Documentation** | **string** | English language documentation for a component. It can contain HTML markup and documentation tags (similar to Javadoc tags). The first sentence of the package documentation is a complete sentence that identifies the component by name and summarizes the purpose of the component. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

