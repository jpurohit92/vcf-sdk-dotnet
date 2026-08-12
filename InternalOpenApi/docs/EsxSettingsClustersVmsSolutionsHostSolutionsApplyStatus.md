# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsSolutionsHostSolutionsApplyStatus
The Esx.Settings.Clusters.Vms.Solutions.HostSolutionsApplyStatus schema contains properties that describe the apply status of solutions with deployment type *Esx.Settings.Clusters.Vms.DeploymentType.EVERY_HOST_PINNED*.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | [**EsxSettingsClustersVmsSolutionsApplyStatus**](EsxSettingsClustersVmsSolutionsApplyStatus.md) | Aggregated apply status of the solutions.  This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; if the apply operation is not completed for solutions with deployment type *Esx.Settings.Clusters.Vms.DeploymentType.EVERY_HOST_PINNED*. | [optional] 
**HostStatuses** | [**Dictionary&lt;string, EsxSettingsClustersVmsSolutionsHostApplyStatus&gt;**](EsxSettingsClustersVmsSolutionsHostApplyStatus.md) | The apply status of the hosts that were part of the apply operation.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;HostSystem&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

