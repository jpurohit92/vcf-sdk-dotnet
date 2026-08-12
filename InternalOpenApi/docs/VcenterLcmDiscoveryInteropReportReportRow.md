# Vcenter.Automation.OpenApi.Model.VcenterLcmDiscoveryInteropReportReportRow
The Vcenter.Lcm.Discovery.InteropReport.ReportRow schema contains the interoperability between a given product and the target product.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Product** | [**VcenterLcmDiscoveryProduct**](VcenterLcmDiscoveryProduct.md) | The product to compare to the target product. | 
**Compatible** | **bool** | Defines whether the product is compatible against the target product. | 
**CompatibleReleases** | [**List&lt;VcenterLcmDiscoveryInteropReportReleaseInfo&gt;**](VcenterLcmDiscoveryInteropReportReleaseInfo.md) | A list of compatible releases of the product with the target product. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

