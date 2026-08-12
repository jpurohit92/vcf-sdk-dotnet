# Vcenter.Automation.OpenApi.Model.VcenterIdentityProvidersOauth2AuthenticationMethod
The Vcenter.Identity.Providers.Oauth2AuthenticationMethod schema contains the possible types of OAuth2 authentication methods.  Possible values:   - `CLIENT_SECRET_BASIC`: Clients that have received a client_secret value from the Authorization Server, authenticate with the Authorization Server in accordance with Section 3.2.1 of OAuth 2.0 [RFC6749] using the HTTP Basic authentication scheme.   - `CLIENT_SECRET_POST`: Clients that have received a client_secret value from the Authorization Server, authenticate with the Authorization Server in accordance with Section 3.2.1 of OAuth 2.0 [RFC6749] by including the Client Credentials in the request body.   - `CLIENT_SECRET_JWT`: Clients that have received a client_secret value from the Authorization Server, create a JWT using an HMAC SHA algorithm, such as HMAC SHA-256. The HMAC (Hash-based Message Authentication Code) is calculated using the octets of the UTF-8 representation of the client_secret as the shared key.   - `PRIVATE_KEY_JWT`: Clients that have registered a public key sign a JWT using that key. The client authenticates in accordance with JSON Web Token (JWT) Profile for OAuth 2.0 Client Authentication and Authorization Grants [OAuth.JWT] and Assertion Framework for OAuth 2.0 Client Authentication and Authorization Grants [OAuth.Assertions].   This enumeration was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

