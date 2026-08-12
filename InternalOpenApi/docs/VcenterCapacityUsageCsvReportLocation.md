# Vcenter.Automation.OpenApi.Model.VcenterCapacityUsageCsvReportLocation
The Vcenter.Capacity.Usage.CsvReportLocation schema contains the URI location to download the report from, as well as a token required (as a header on the HTTP request) to get the bundle. The validity of the token is 30 minutes as best attempt. After the token expires, any attempt to call the URI with said token will fail.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | CSV Report Download URI.  This property was added in __vSphere API 9.1.0.0__. | 
**AuthToken** | [**VcenterCapacityUsageToken**](VcenterCapacityUsageToken.md) | Information about the authentication token required in the HTTP GET request to access the report.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

