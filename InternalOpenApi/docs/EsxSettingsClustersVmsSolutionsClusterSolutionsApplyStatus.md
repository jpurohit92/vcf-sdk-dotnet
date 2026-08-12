# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsSolutionsClusterSolutionsApplyStatus
The Esx.Settings.Clusters.Vms.Solutions.ClusterSolutionsApplyStatus schema contains properties that describe the apply status of solutions with deployment type *Esx.Settings.Clusters.Vms.DeploymentType.CLUSTER_VM_SET*.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | [**EsxSettingsClustersVmsSolutionsApplyStatus**](EsxSettingsClustersVmsSolutionsApplyStatus.md) | Aggregated apply status of the solutions.  This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; if the apply operation is not completed for solutions with deployment type *Esx.Settings.Clusters.Vms.DeploymentType.CLUSTER_VM_SET*. | [optional] 
**SolutionStatuses** | [**Dictionary&lt;string, EsxSettingsClustersVmsSolutionsClusterSolutionApplyStatus&gt;**](EsxSettingsClustersVmsSolutionsClusterSolutionApplyStatus.md) | The apply status of the solutions that were part of the apply operation.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.vms.SystemVmSolution&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.vms.SystemVmSolution&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

