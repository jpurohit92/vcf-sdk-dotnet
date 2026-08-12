# Vcenter.ViJson.OpenApi.Model.PbmExtendedElementDescription

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | Display label.  | 
**Summary** | **string** | Summary description.  | 
**Key** | **string** | Enumeration or literal ID being described.  | 
**MessageCatalogKeyPrefix** | **string** | Key to the localized message string in the catalog.  If the localized string contains parameters, values to the parameters will be provided in #messageArg. E.g: If the message in the catalog is \&quot;IP address is {address}\&quot;, value for \&quot;address\&quot; will be provided by #messageArg. Both summary and label in ElementDescription will have a corresponding entry in the message catalog with the keys &amp;lt;messageCatalogKeyPrefix&amp;gt;.summary and &amp;lt;messageCatalogKeyPrefix&amp;gt;.label respectively. ElementDescription.summary and ElementDescription.label will contain the strings in server locale.  | 
**MessageArg** | [**List&lt;KeyAnyValue&gt;**](KeyAnyValue.md) | Provides named arguments that can be used to localize the message in the catalog.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

