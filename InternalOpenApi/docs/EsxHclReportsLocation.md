# Vcenter.Automation.OpenApi.Model.EsxHclReportsLocation
The Esx.Hcl.Reports.Location schema contains the URI location to download generated compatibility report, as well as a token required (as a header on the HTTP GET request) to get the report. The validity of the token is 5 minutes. After the token expires, any attempt to call the URI with said token will fail.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | Compatibility report download URL. | 
**ReportToken** | [**EsxHclReportsToken**](EsxHclReportsToken.md) | Information about the token required in the HTTP GET request to download the compatibility report. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

