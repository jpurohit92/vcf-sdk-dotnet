# Vcenter.Automation.OpenApi.Model.VcenterLcmDiscoveryInteropReportResult
The Vcenter.Lcm.Discovery.InteropReport.Result schema contains the result of interoperability report creation operation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Report** | [**VcenterLcmDiscoveryInteropReportReport**](VcenterLcmDiscoveryInteropReportReport.md) | The interoperability report. | 
**CsvReport** | **string** | The identifier of CSV formatted interopability report.    com.vmware.vcenter.lcm.report.Report#get provides location where the CSV report can be downloaded from based on the csvReport.  missing or &#x60;null&#x60; in case of errors reported in *Vcenter.Lcm.Discovery.InteropReport.Report.issues*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.lcm.report&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.lcm.report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

