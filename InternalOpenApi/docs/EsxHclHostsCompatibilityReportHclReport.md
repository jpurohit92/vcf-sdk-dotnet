# Vcenter.Automation.OpenApi.Model.EsxHclHostsCompatibilityReportHclReport
This Esx.Hcl.Hosts.CompatibilityReport.HclReport represents the hardware compatibility report generated for a specific host and target ESXi release.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | **string** | FQDN identifying the ESXi host that the report refers to. | 
**TargetRelease** | **string** | Indicates for which ESXi release the report is generated. | 
**ServerHcl** | [**EsxHclHostsCompatibilityReportServerHclInfo**](EsxHclHostsCompatibilityReportServerHclInfo.md) | Lists compatibility information for the ESXi&#39;s server part. | 
**DevicesHcl** | [**List&lt;EsxHclHostsCompatibilityReportDeviceHclInfo&gt;**](EsxHclHostsCompatibilityReportDeviceHclInfo.md) | Lists compatibility information for discoverable PCI devices of the host.  If missing or &#x60;null&#x60; the server is not compatible with the requested release and the PCI devices cannot be checked. | [optional] 
**GeneratedAt** | **DateTime** | Specifies the time the report was generated. | 
**Notifications** | [**EsxHclNotifications**](EsxHclNotifications.md) | Notifications returned by the operation. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

