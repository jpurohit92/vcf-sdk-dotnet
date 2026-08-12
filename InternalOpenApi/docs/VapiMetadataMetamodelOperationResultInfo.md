# Vcenter.Automation.OpenApi.Model.VapiMetadataMetamodelOperationResultInfo
The Vapi.Metadata.Metamodel.OperationResultInfo schema contains the metamodel information of an operation result element.    An operation accepts a list of parameters and returns a result or an error. The Vapi.Metadata.Metamodel.OperationResultInfo describes the result element of an operation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | [**VapiMetadataMetamodelType**](VapiMetadataMetamodelType.md) | Type information of the operation result element. | 
**Metadata** | [**Dictionary&lt;string, VapiMetadataMetamodelElementMap&gt;**](VapiMetadataMetamodelElementMap.md) | Generic metadata elements for the service element. The key in the map is the name of the metadata element and the value is the data associated with that metadata element.    The *Vapi.Metadata.Metamodel.MetadataIdentifier* contains possible string values for keys in the map. | 
**Documentation** | **string** | English language documentation for the operation result element. It can contain HTML markup and Javadoc tags. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

