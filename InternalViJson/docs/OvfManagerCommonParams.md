# Vcenter.ViJson.OpenApi.Model.OvfManagerCommonParams

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Locale** | **string** | The locale-identifier to choose from the descriptor.  If empty, the default locale on the server is used.  | 
**DeploymentOption** | **string** | The key of the chosen deployment option.  If empty, the default option is chosen. The list of possible deployment options is returned in the result of parseDescriptor.  | 
**MsgBundle** | [**List&lt;KeyValue&gt;**](KeyValue.md) | An optional set of localization strings to be used.  The server will use these message strings to localize information in the result and in error and warning messages.  This argument allows a client to pass messages from external string bundles. The client is responsible for selecting the right string bundle (based on locale) and parsing the external string bundle. The passed in key/value pairs are looked up before any messages included in the OVF descriptor itself.  | [optional] 
**ImportOption** | **List&lt;string&gt;** | An optional argument for modifying the OVF parsing.  When the server parses an OVF descriptor a set of options can be used to modify the parsing. The argument is a list of keywords.  To get a list of supported keywords see *OvfManager.ovfImportOption*. Unknown options will be ignored by the server.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

