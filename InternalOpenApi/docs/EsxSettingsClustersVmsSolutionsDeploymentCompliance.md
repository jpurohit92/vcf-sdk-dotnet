# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsSolutionsDeploymentCompliance
The Esx.Settings.Clusters.Vms.Solutions.DeploymentCompliance schema contains properties that describe the compliance of a given VM deployment. See *Esx.Settings.Clusters.Vms.Solutions.DeploymentInfo*  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Compliance status of the deployment.  Possible values:   - &#x60;COMPLIANT&#x60;: The status is compliant with the desired solution specification.   - &#x60;NON_COMPLIANT&#x60;: The status is __non__-compliant with the desired solution specification.   - &#x60;INCOMPATIBLE&#x60;: Target state is incompatible with the system.   For more information see: *Esx.Settings.Clusters.Vms.Solutions.ComplianceStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**Notifications** | [**EsxSettingsNotifications**](EsxSettingsNotifications.md) | Notifications describing the compliance result.  This property was added in __vSphere API 9.0.0.0__. | 
**Deployment** | [**EsxSettingsClustersVmsSolutionsDeploymentInfo**](EsxSettingsClustersVmsSolutionsDeploymentInfo.md) | The current VM deployment.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

