# Vcenter.Automation.OpenApi.Model.VapiMetadataCliCommandInfo
The Vapi.Metadata.Cli.Command.Info schema contains information about a command. It includes the identity of the command, a description, information about the resource and operation that implement the command, and CLI-specific information for the command.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identity** | [**VapiMetadataCliCommandIdentity**](VapiMetadataCliCommandIdentity.md) | Basic command identity. | 
**Description** | **string** | The text description displayed to the user in help output. | 
**ServiceId** | **string** | The service identifier that contains the operations for this CLI command.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vapi.service&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vapi.service&#x60;. | 
**OperationId** | **string** | The operation identifier corresponding to this CLI command.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vapi.operation&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vapi.operation&#x60;. | 
**Options** | [**List&lt;VapiMetadataCliCommandOptionInfo&gt;**](VapiMetadataCliCommandOptionInfo.md) | The input for this command. | 
**Formatter** | **string** | The formatter to use when displaying the output of this command.  Possible values:   - &#x60;SIMPLE&#x60;: Displays command output as it is.   - &#x60;TABLE&#x60;: Displays command output in table format.   - &#x60;JSON&#x60;: Displays command output in JSON format.   - &#x60;XML&#x60;: Displays command output in XML format.   - &#x60;CSV&#x60;: Displays command output in CSV format.   - &#x60;HTML&#x60;: Displays command output in HTML format.   For more information see: *Vapi.Metadata.Cli.Command.FormatterType*.  If not present, client can choose a default output formatter. | [optional] 
**OutputFieldList** | [**List&lt;VapiMetadataCliCommandOutputInfo&gt;**](VapiMetadataCliCommandOutputInfo.md) | List of output structure name and output field info. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

