# Vcenter.Automation.OpenApi.Model.EsxHclHostsCompatibilityReportServerCompatibility
This Esx.Hcl.Hosts.CompatibilityReport.ServerCompatibility schema contains properties that provide the compatibility information for a server model, cpu and BIOS.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BiosConstraints** | [**List&lt;EsxHclHostsCompatibilityReportBiosConstraint&gt;**](EsxHclHostsCompatibilityReportBiosConstraint.md) | Lists the BIOS constraints that the target ESXi release has for this server.  If missing or &#x60;null&#x60; no constraints are present as server is either not compatible or compatibility information is not found. | [optional] 
**CpuSeries** | **string** | The CPU series name. | 
**SupportedReleases** | **List&lt;string&gt;** | Provides information about supported releases for this entry.  If missing or &#x60;null&#x60; server is compatible with the given target release. | [optional] 
**VcgLink** | **string** | Provides link to the VMware Compatibility Guide for further information on the compatibility. | 
**Notes** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | Information that needs to be taken into account when considering this server hardware compatibility.  Only set if there is any information reported. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

