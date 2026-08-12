# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsSolutionsClusterSolutionsApplyFilterSpec
The Esx.Settings.Clusters.Vms.Solutions.ClusterSolutionsApplyFilterSpec schema contains properties that describe a filter that to be used for applying the desired specification of solutions with deployment type *Esx.Settings.Clusters.Vms.DeploymentType.CLUSTER_VM_SET* to a given cluster.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Solutions** | **List&lt;string&gt;** | Specific solutions within the cluster to be considered during the execution of the apply operation.  This property was added in __vSphere API 9.0.0.0__.  if missing or &#x60;null&#x60; or empty, all solutions are applied.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.esx.settings.vms.SystemVmSolution&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.esx.settings.vms.SystemVmSolution&#x60;. | [optional] 
**DeploymentUnits** | **List&lt;string&gt;** | Deployment units on which solutions that are specified by this structure need to be applied.    The deployment unit represents a single VM instance deployment. It is returned by the #checkCompliance operation.     This filtering is not supported in case of subsequent LifecycleHook#processDynamicUpdate is invoked.   This property was added in __vSphere API 9.0.0.0__.  if missing or &#x60;null&#x60; or empty, the configured solutions by solutions are applied on all of the deployment units in the cluster.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.esx.settings.vms.SystemVmDeploymentUnit&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.esx.settings.vms.SystemVmDeploymentUnit&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

