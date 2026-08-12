# Vcenter.ViJson.OpenApi.Model.HostInternetScsiHbaParamValue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The name of the option using dot notation to reflect the option&#39;s position in a hierarchy.  For example, you might have an option called \&quot;Ethernet\&quot; and another option that is a child of that called \&quot;Connection\&quot;. In this case, the key for the latter could be defined as \&quot;Ethernet.Connection\&quot;  | 
**Value** | [**Any**](Any.md) | The value of the option.  The Any data object type enables you to define any value for the option. Typically, however, the value of an option is of type String or Integer.  | [optional] 
**IsInherited** | **bool** | Indicates if the value is inherited from some other source.  If unset, the value is not inheritable. isInherited can be modified only if it has already been set. If value is to being modified, isInherited should be set to true. Setting isInherited to false will result in the value being once again inherited from the source.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

