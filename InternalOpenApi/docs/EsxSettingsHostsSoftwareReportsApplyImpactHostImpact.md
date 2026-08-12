# Vcenter.Automation.OpenApi.Model.EsxSettingsHostsSoftwareReportsApplyImpactHostImpact
The Esx.Settings.Hosts.Software.Reports.ApplyImpact.HostImpact schema contains properties that describe the summary of how the standalone ESXi host will be impacted during an apply operation.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Impact** | [**List&lt;EsxSettingsHostsSoftwareReportsApplyImpactImpact&gt;**](EsxSettingsHostsSoftwareReportsApplyImpactImpact.md) | Impact of steps performed during the apply operation.  This property was added in __vSphere API 8.0.0.1__. | 
**Commit** | **string** | Identifier of the commit on which the impact is generated.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. | 
**HostInfo** | [**EsxSettingsHostInfo**](EsxSettingsHostInfo.md) | Information of the host.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

