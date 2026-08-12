# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsSolutionsHostApplyStatus
The Esx.Settings.Clusters.Vms.Solutions.HostApplyStatus schema contains properties that describe the apply status for a specific host.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | [**EsxSettingsClustersVmsSolutionsApplyStatus**](EsxSettingsClustersVmsSolutionsApplyStatus.md) | Aggregated apply status of the solutions on the host.  This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; if the apply operation is not completed for the specified host. | [optional] 
**SolutionStatuses** | [**Dictionary&lt;string, EsxSettingsClustersVmsSolutionsApplyStatus&gt;**](EsxSettingsClustersVmsSolutionsApplyStatus.md) | The apply status of the different solutions on the host.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.vms.SystemVmSolution&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.vms.SystemVmSolution&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

