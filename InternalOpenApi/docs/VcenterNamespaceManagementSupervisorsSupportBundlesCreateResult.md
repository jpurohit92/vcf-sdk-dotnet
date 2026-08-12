# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSupportBundlesCreateResult
The Vcenter.NamespaceManagement.Supervisors.SupportBundles.CreateResult schema contains the URI to download the Supervisor support bundle from, as well as a token required (as the body on the HTTP POST request) to generate the bundle. The validity of the token is 5 minutes. After the token expires, any attempt to call the URI with the token will fail.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | Support Bundle Download URL.  This property was added in __vSphere API 9.1.0.0__. | 
**SupportBundleToken** | [**VcenterNamespaceManagementSupervisorsSupportBundlesToken**](VcenterNamespaceManagementSupervisorsSupportBundlesToken.md) | Information about the token required in the HTTP POST request to #CreateResult.url to generate the support bundle.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

