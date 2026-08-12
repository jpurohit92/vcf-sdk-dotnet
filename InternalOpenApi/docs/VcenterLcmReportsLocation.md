# Vcenter.Automation.OpenApi.Model.VcenterLcmReportsLocation
The Vcenter.Lcm.Reports.Location schema contains the URI location to download the report from, as well as a token required (as a header on the HTTP request) to get the bundle. The validity of the token is 5 minutes as best attempt. After the token expires, any attempt to call the URI with said token will fail.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | Report Download URI. | 
**DownloadFileToken** | [**VcenterLcmReportsToken**](VcenterLcmReportsToken.md) | Information about the token required in the HTTP GET request to retrieve the report | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

