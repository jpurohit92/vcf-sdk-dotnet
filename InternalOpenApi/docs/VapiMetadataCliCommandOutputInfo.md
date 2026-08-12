# Vcenter.Automation.OpenApi.Model.VapiMetadataCliCommandOutputInfo
The Vapi.Metadata.Cli.Command.OutputInfo schema describes the names used by the CLI to display the properties of a schema element in the interface definition language as well as the order in which the properties will be displayed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StructureId** | **string** | Name of the schema.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vapi.structure&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vapi.structure&#x60;. | 
**OutputFields** | [**List&lt;VapiMetadataCliCommandOutputFieldInfo&gt;**](VapiMetadataCliCommandOutputFieldInfo.md) | The order in which the properties of the schema will be displayed by the CLI as well as the names used to display the properties. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

