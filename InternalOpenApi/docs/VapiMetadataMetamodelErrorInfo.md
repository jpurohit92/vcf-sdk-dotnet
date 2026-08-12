# Vcenter.Automation.OpenApi.Model.VapiMetadataMetamodelErrorInfo
The Vapi.Metadata.Metamodel.ErrorInfo schema contains the metadata information about the error elements contained in an operation element.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StructureId** | **string** | Identifier for the structure element corresponding to the error that is being reported by the operation.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vapi.structure&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vapi.structure&#x60;. | 
**Documentation** | **string** | The English language documentation for the error element. It can contain HTML markup and Javadoc tags. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

