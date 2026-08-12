# Vcenter.Automation.OpenApi.Model.ContentSecurityPoliciesInfo
Representation of a security policy  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policy** | **string** | Identifier of the security policy  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.SecurityPolicy&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.SecurityPolicy&#x60;. | 
**Name** | **string** | Name of the security policy  This property was added in __vSphere API 7.0.3.0__. | 
**ItemTypeRules** | **Dictionary&lt;string, string&gt;** | Map of content library item type and rule types The rules can be associated with a security policy. When the security policy is applied to a content library, these rules will be used to validate specific item type.  Possible values:   - &#x60;OVF_STRICT_VERIFICATION&#x60;: This rule indicates that an OVF/OVA item can only be imported or synced to a content library if its certificate is valid and signed by a trusted CA.   For more information see: *Content.SecurityRuleType*.  This property was added in __vSphere API 7.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

