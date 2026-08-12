# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsTransitionTransitionSpec
The Esx.Settings.Clusters.Vms.Transition.TransitionSpec schema contains properties that describe the specification for transitioning a System VM Solution.    Supported only for solutions with deployment type *Esx.Settings.Clusters.Vms.DeploymentType.CLUSTER_VM_SET*.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceCluster** | **string** | Cluster to transition from.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ClusterComputeResource&#x60;. | 
**Solution** | [**EsxSettingsClustersVmsSolutionSpec**](EsxSettingsClustersVmsSolutionSpec.md) | Target desired solution specification in vLCM.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

