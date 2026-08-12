# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsSolutionsClusterSolutionApplyStatus
The Esx.Settings.Clusters.Vms.Solutions.ClusterSolutionApplyStatus schema contains properties that describe the apply status for a specific solution.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | [**EsxSettingsClustersVmsSolutionsApplyStatus**](EsxSettingsClustersVmsSolutionsApplyStatus.md) | Aggregated apply status for the deployment units of the solution.  This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; if the apply operation is not completed for the specified deployment unit. | [optional] 
**DeploymentUnitStatuses** | [**Dictionary&lt;string, EsxSettingsClustersVmsSolutionsApplyStatus&gt;**](EsxSettingsClustersVmsSolutionsApplyStatus.md) | The apply status for the different deployment units of the solution.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.vms.SystemVmDeploymentUnit&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.vms.SystemVmDeploymentUnit&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

