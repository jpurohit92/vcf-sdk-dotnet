# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsTransitionEnableSpec
The Esx.Settings.Clusters.Vms.Transition.EnableSpec schema contains properties that describe specification for enablement of EAM managed solution in vLCM.    Supported only for solutions with deployment type *Esx.Settings.Clusters.Vms.DeploymentType.EVERY_HOST_PINNED*.   This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EamAgencyId** | **string** | Identifier of the host pinned solution in EAM (EAM agency).  This property was added in __vSphere API 9.0.0.0__. | 
**Solution** | [**EsxSettingsClustersVmsSolutionSpec**](EsxSettingsClustersVmsSolutionSpec.md) | Target desired solution specification in vLCM.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

