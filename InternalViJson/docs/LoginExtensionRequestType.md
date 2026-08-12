# Vcenter.ViJson.OpenApi.Model.LoginExtensionRequestType
The parameters of *SessionManager.LoginExtension*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExtensionKey** | **string** | Key of extension that is logging in.  | 
**Base64SignedCredentials** | **string** | base-64 encoding of the SHA-1 digest of the string \&quot;login\&quot; signed with the extension&#39;s private RSA key using PKCS#1 padding.  | 
**Locale** | **string** | A two-character ISO-639 language ID (like \&quot;en\&quot;) optionally followed by an underscore and a two-character ISO 3166 country ID (like \&quot;US\&quot;).  Examples are \&quot;de\&quot;, \&quot;fr\\_CA\&quot;, \&quot;zh\&quot;, \&quot;zh\\_CN\&quot;, and \&quot;zh\\_TW\&quot;. Note: The method uses the server default locale when a locale is not provided. This default can be configured in the server configuration file. If unspecified, it defaults to the locale of the server environment or English (\&quot;en\&quot;) if unsupported.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

