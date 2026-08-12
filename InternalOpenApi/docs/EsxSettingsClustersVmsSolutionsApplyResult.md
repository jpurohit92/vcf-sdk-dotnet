# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsSolutionsApplyResult
The Esx.Settings.Clusters.Vms.Solutions.ApplyResult schema contains properties that describe the result of an *POST /esx/settings/clusters/{cluster}/vms/solutions?action=apply* operation.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | [**EsxSettingsClustersVmsSolutionsApplyStatus**](EsxSettingsClustersVmsSolutionsApplyStatus.md) | Aggregated status of an apply operation.  This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; if the apply operation is in progress. | [optional] 
**HostSolutionsStatus** | [**EsxSettingsClustersVmsSolutionsHostSolutionsApplyStatus**](EsxSettingsClustersVmsSolutionsHostSolutionsApplyStatus.md) | The apply status of all solutions with deployment type *Esx.Settings.Clusters.Vms.DeploymentType.EVERY_HOST_PINNED* that were part of the apply operation.  This property was added in __vSphere API 9.0.0.0__. | 
**ClusterSolutionsStatus** | [**EsxSettingsClustersVmsSolutionsClusterSolutionsApplyStatus**](EsxSettingsClustersVmsSolutionsClusterSolutionsApplyStatus.md) | The apply status of all solutions with deployment type *Esx.Settings.Clusters.Vms.DeploymentType.CLUSTER_VM_SET* that were part of the apply operation.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

