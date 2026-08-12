# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareReportsApplyImpactApplyImpactSpec
The Esx.Settings.Clusters.Software.Reports.ApplyImpact.ApplyImpactSpec schema contains properties that describe the specification to be used for getting the impact of an apply operation on an ESXi cluster.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hosts** | **List&lt;string&gt;** | The specific hosts for which an impact is to be generated.  This property was added in __vSphere API 7.0.0.0__.  if missing or &#x60;null&#x60; or empty impact is generated for all hosts within the cluster.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;HostSystem&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

