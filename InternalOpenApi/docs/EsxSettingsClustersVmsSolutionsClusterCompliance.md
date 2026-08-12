# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsSolutionsClusterCompliance
The Esx.Settings.Clusters.Vms.Solutions.ClusterCompliance schema contains properties that describe the result of the compliance *POST /esx/settings/clusters/{cluster}/vms/solutions?action=check-compliance* operation.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Aggregated status of the compliance check operation.  Possible values:   - &#x60;COMPLIANT&#x60;: The status is compliant with the desired solution specification.   - &#x60;NON_COMPLIANT&#x60;: The status is __non__-compliant with the desired solution specification.   - &#x60;INCOMPATIBLE&#x60;: Target state is incompatible with the system.   For more information see: *Esx.Settings.Clusters.Vms.Solutions.ComplianceStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**HostSolutionsStatus** | [**EsxSettingsClustersVmsSolutionsHostSolutionsCompliance**](EsxSettingsClustersVmsSolutionsHostSolutionsCompliance.md) | Compliance status of all solutions with deployment type *Esx.Settings.Clusters.Vms.DeploymentType.EVERY_HOST_PINNED* that were part of the *POST /esx/settings/clusters/{cluster}/vms/solutions?action&#x3D;check-compliance* operation.  This property was added in __vSphere API 9.0.0.0__. | 
**ClusterSolutionsStatus** | [**EsxSettingsClustersVmsSolutionsClusterSolutionsCompliance**](EsxSettingsClustersVmsSolutionsClusterSolutionsCompliance.md) | Compliance status of all solutions with deployment type *Esx.Settings.Clusters.Vms.DeploymentType.CLUSTER_VM_SET* that were part of the *POST /esx/settings/clusters/{cluster}/vms/solutions?action&#x3D;check-compliance* operation.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

