# Vcenter.Automation.OpenApi.Model.EsxHclHostsCompatibilityReportResult
The Esx.Hcl.Hosts.CompatibilityReport.Result schema contains the result of hardware compatibility report creation operation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Report** | [**EsxHclHostsCompatibilityReportHclReport**](EsxHclHostsCompatibilityReportHclReport.md) | The hardware compatibility report. | 
**Identifier** | **string** | The identifier of the compatibility report.    *GET /esx/hcl/reports/{report}* provides location where a file based report based on the Esx.Hcl.Hosts.CompatibilityReport.HclReport can be downloaded using this identifier.  missing or &#x60;null&#x60; in case of error reported in *Esx.Hcl.Hosts.CompatibilityReport.HclReport.notifications*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.hcl.resources.CompatibilityReport&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.hcl.resources.CompatibilityReport&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

