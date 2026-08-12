# Vcenter.Automation.OpenApi.Model.VapiMetadataCliCommandOptionInfo
The Vapi.Metadata.Cli.Command.OptionInfo schema describes information about a specific input option of a command.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LongOption** | **string** | The long option name of the parameter as used by the user. | 
**ShortOption** | **string** | The single character value option name.  If not present, there&#39;s no single character option for the parameter. | [optional] 
**FieldName** | **string** | The fully qualified name of the option referred to by the operation element in *Vapi.Metadata.Cli.Command.Info.operation_id*. | 
**Description** | **string** | The description of the option to be displayed to the user when they request usage information for a CLI command. | 
**Type** | **string** | The type of option. This is used to display information about what kind of data is expected (string, number, boolean, etc.) for the option when they request usage information for a CLI command. For enumerated type this stores the fully qualified enumerated type id. | 
**Generic** | **string** | This is used to tell the user whether the option is required or optional, or whether they can specify the option multiple times.  Possible values:   - &#x60;NONE&#x60;: Default case.   - &#x60;OPTIONAL&#x60;: Input parameter is an optional.   - &#x60;LIST&#x60;: Input parameter is a list.   - &#x60;OPTIONAL_LIST&#x60;: Input parameter is an optional of type list.  This constant was added in __vSphere API 6.5__.   - &#x60;LIST_OPTIONAL&#x60;: Input parameter is a list of optionals.  This constant was added in __vSphere API 6.5__.   For more information see: *Vapi.Metadata.Cli.Command.GenericType*. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

