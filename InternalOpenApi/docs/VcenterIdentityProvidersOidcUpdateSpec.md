# Vcenter.Automation.OpenApi.Model.VcenterIdentityProvidersOidcUpdateSpec
The Vcenter.Identity.Providers.OidcUpdateSpec schema contains the information used to update the OIDC identity provider.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiscoveryEndpoint** | **string** | Endpoint to retrieve the provider metadata  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, leaves value unchanged. | [optional] 
**ClientId** | **string** | Client identifier to connect to the provider  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, leaves value unchanged. | [optional] 
**ClientSecret** | **string** | The secret shared between the client and the provider  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, leaves value unchanged. | [optional] 
**ClaimMap** | **Dictionary&lt;string, Dictionary&lt;string, List&lt;string&gt;&gt;&gt;** | The map used to transform an OAuth2 claim to a corresponding claim that vCenter Server understands. Currently only the key \&quot;perms\&quot; is supported. The key \&quot;perms\&quot; is used for mapping the \&quot;perms\&quot; claim of incoming JWT. The value is another map with an external group as the key and a vCenter Server group as value.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, leaves value unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

