# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupportBundleLocation
This schema is deprecated as of __vSphere API 9.1.0.0__.  The Vcenter.NamespaceManagement.SupportBundle.Location schema contains the URI to download the per-cluster support bundle from, as well as a token required (as the body on the HTTP request) to generate the bundle. The validity of the token is 5 minutes. After the token expires, any attempt to call the URI with the token will fail.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  Support Bundle Download URL.  This property was added in __vSphere API 7.0.0.0__. | 
**WcpSupportBundleToken** | [**VcenterNamespaceManagementSupportBundleToken**](VcenterNamespaceManagementSupportBundleToken.md) | This property is deprecated as of __vSphere API 9.1.0.0__.  Information about the token required in the HTTP POST request to generate the support bundle.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

