# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsSolutionsHostSolutionsCompliance
The Esx.Settings.Clusters.Vms.Solutions.HostSolutionsCompliance schema contains properties that describe the compliance of solutions with deployment type *Esx.Settings.Clusters.Vms.DeploymentType.EVERY_HOST_PINNED*.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Aggregated compliance status for all solutions for which a compliance check was requested.  Possible values:   - &#x60;COMPLIANT&#x60;: The status is compliant with the desired solution specification.   - &#x60;NON_COMPLIANT&#x60;: The status is __non__-compliant with the desired solution specification.   - &#x60;INCOMPATIBLE&#x60;: Target state is incompatible with the system.   For more information see: *Esx.Settings.Clusters.Vms.Solutions.ComplianceStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**Compliances** | [**Dictionary&lt;string, EsxSettingsClustersVmsSolutionsHostCompliance&gt;**](EsxSettingsClustersVmsSolutionsHostCompliance.md) | Compliance status of the hosts that were part of the check compliance operation.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;HostSystem&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

