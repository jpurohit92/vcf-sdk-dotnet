# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSupportBundlesToken
The Vcenter.NamespaceManagement.Supervisors.SupportBundles.Token schema contains information about the token required in the HTTP POST request to generate the support bundle.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Token** | **string** | A one-time, short-lived token required to be provided in the HTTP POST request to generate the support bundle. This token needs to be passed in as the body of the HTTP POST request to #CreateResult.url with name \&quot;wcp-support-bundle-token\&quot;.  This property was added in __vSphere API 9.1.0.0__. | 
**Expiry** | **DateTime** | Time when the token expires represented in ISO-8601 format.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

