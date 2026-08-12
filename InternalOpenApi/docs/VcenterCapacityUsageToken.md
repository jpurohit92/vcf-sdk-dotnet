# Vcenter.Automation.OpenApi.Model.VcenterCapacityUsageToken
The Vcenter.Capacity.Usage.Token schema contains information about the token required in the HTTP GET request to generate the report.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | A one-time, short-lived token required in the HTTP header of the request to the url. This token needs to be passed in as a header with the name \&quot;session-id\&quot;.  This property was added in __vSphere API 9.1.0.0__. | 
**Expiry** | **DateTime** | Expiry time of the token.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

