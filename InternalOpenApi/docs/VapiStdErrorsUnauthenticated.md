# Vcenter.Automation.OpenApi.Model.VapiStdErrorsUnauthenticated

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Challenge** | **string** | Indicates the authentication challenges applicable to the target API provider. It can be used by a client to discover the correct authentication scheme to use. The exact syntax of the value is defined by the specific provider, the protocol and authentication schemes used.    For example, a provider using REST may adhere to the WWW-Authenticate HTTP header specification, RFC7235, section 4.1. In this case an example challenge value may be: SIGN realm&#x3D;\&quot;27da1358-2ba4-11e9-b210-d663bd873d93\&quot;,sts&#x3D;\&quot;http://vcenter/sso?vsphere.local\&quot;, Basic realm&#x3D;\&quot;vCenter\&quot;  This property was added in __vSphere API 7.0.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

