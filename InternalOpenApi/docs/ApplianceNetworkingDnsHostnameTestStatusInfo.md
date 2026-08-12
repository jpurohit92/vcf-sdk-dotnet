# Vcenter.Automation.OpenApi.Model.ApplianceNetworkingDnsHostnameTestStatusInfo
Appliance.Networking.Dns.Hostname.TestStatusInfo schema Overall test result

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Overall status of tests run.  Possible values:   - &#x60;orange&#x60;: In case data has more than one test, this indicates not all tests were successful   - &#x60;green&#x60;: All tests were successful for given data   - &#x60;red&#x60;: All tests failed for given data   For more information see: *Appliance.Networking.Dns.Hostname.TestStatus*. | 
**Messages** | [**List&lt;ApplianceNetworkingDnsHostnameMessage&gt;**](ApplianceNetworkingDnsHostnameMessage.md) | messages | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

