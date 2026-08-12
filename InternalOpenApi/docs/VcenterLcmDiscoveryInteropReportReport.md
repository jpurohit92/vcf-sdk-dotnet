# Vcenter.Automation.OpenApi.Model.VcenterLcmDiscoveryInteropReportReport
The Vcenter.Lcm.Discovery.InteropReport.Report schema contains the interoperability report between the target product and the other registered products in the vCenter Server instance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateCreated** | **DateTime** | Time when the report is created. | 
**TargetProduct** | [**VcenterLcmDiscoveryProduct**](VcenterLcmDiscoveryProduct.md) | A product against the other products are compared to. Only vCenter Server is supported. | 
**Products** | [**List&lt;VcenterLcmDiscoveryInteropReportReportRow&gt;**](VcenterLcmDiscoveryInteropReportReportRow.md) | Interoperability matrix for the supplied target product and the other registered products. | 
**Issues** | [**VcenterLcmNotifications**](VcenterLcmNotifications.md) | Lists of issues encountered during report creation.  set if any issues encountered. | [optional] 
**Summary** | [**VcenterLcmDiscoveryInteropReportReportSummary**](VcenterLcmDiscoveryInteropReportReportSummary.md) | A summary of the interoperability matrix. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

