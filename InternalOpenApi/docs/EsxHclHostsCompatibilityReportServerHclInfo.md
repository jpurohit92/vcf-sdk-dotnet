# Vcenter.Automation.OpenApi.Model.EsxHclHostsCompatibilityReportServerHclInfo
This Esx.Hcl.Hosts.CompatibilityReport.ServerHclInfo schema contains properties that describe the server of a ESXi host and its compatibility information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Server** | [**EsxHclServer**](EsxHclServer.md) | Information about the server. | 
**Matches** | [**List&lt;EsxHclHostsCompatibilityReportServerCompatibility&gt;**](EsxHclHostsCompatibilityReportServerCompatibility.md) | Provides information about possible compatibility matches for the given server.    There could be multiple matches returned as there are several possible matches in the Compatibility data. | 
**ModelCompatibility** | **string** | Shows if the server model is compatible with given target ESXi release.  Possible values:   - &#x60;COMPATIBLE&#x60;: When given hardware is certified for the specified ESXi release but no validation of the software of this hardware is performed.   - &#x60;INCOMPATIBLE&#x60;: When given hardware is not certified for the specified ESXi release.   - &#x60;UNAVAILABLE&#x60;: When there is no information about specified hardware.   - &#x60;CERTIFIED&#x60;: When given hardware is certified for the specified ESXi release. Its software is also validated and it is also certified.   - &#x60;NOT_CERTIFIED&#x60;: When given hardware is certified for the specified ESXi release. Its software is also validated and it is not certified.   For more information see: *Esx.Hcl.CompatibilityStatus*. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

