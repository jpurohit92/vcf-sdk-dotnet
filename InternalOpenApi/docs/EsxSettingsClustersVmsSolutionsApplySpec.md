# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsSolutionsApplySpec
The Esx.Settings.Clusters.Vms.Solutions.ApplySpec schema contains properties that describe a specification to be used for applying the desired solution specification to a given cluster.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostSolutions** | [**EsxSettingsClustersVmsSolutionsHostSolutionsApplyFilterSpec**](EsxSettingsClustersVmsSolutionsHostSolutionsApplyFilterSpec.md) | Apply filter for solutions with deployment type *Esx.Settings.Clusters.Vms.DeploymentType.EVERY_HOST_PINNED*.  This property was added in __vSphere API 9.0.0.0__.  if missing or &#x60;null&#x60; or empty and {#member clusterSolutions} is missing or &#x60;null&#x60; or empty, all solutions are applied on the cluster. | [optional] 
**ClusterSolutions** | [**EsxSettingsClustersVmsSolutionsClusterSolutionsApplyFilterSpec**](EsxSettingsClustersVmsSolutionsClusterSolutionsApplyFilterSpec.md) | Apply filter for solutions with deployment type *Esx.Settings.Clusters.Vms.DeploymentType.CLUSTER_VM_SET*.  This property was added in __vSphere API 9.0.0.0__.  if missing or &#x60;null&#x60; or empty and {#member hostSolutions} is missing or &#x60;null&#x60; or empty, all solutions are applied on the cluster. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

