# Vcenter.Automation.OpenApi.Model.ContentTypeInfo
The Content.Type.Info schema describes support for a specific type of data in an *Content.Library.ItemModel*. The Content.Type.Info can be queried through the *Content.Type* resource. Type support describes plugins in the Content Library which can provide metadata on library items and help manage the transfer process by adding dependent files when a current file is added.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | A description of the type support offered by the plugin. | 
**Name** | **string** | The name of the plugin which provides the type support. | 
**Type** | **string** | The type which the plugin supports.    To upload a library item of the type supported by the plugin, the *Content.Library.ItemModel.type* property of the item should be set to this value. | 
**Vendor** | **string** | The name of the vendor who created the type support plugin. | 
**VarVersion** | **string** | The version number of the type support plugin. | 
**SupportedRules** | **List&lt;string&gt;** | List of security rules which can be applied to this item type.  Possible values:   - &#x60;OVF_STRICT_VERIFICATION&#x60;: This rule indicates that an OVF/OVA item can only be imported or synced to a content library if its certificate is valid and signed by a trusted CA.   For more information see: *Content.SecurityRuleType*.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60; no security rule can be associated with this item type. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

