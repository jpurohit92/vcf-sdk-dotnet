# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsSolutionsListResult
The Esx.Settings.Clusters.Vms.Solutions.ListResult schema contains properties that describe the desired specification of the solutions in a given cluster specified by the *Esx.Settings.Clusters.Vms.Solutions.FilterSpec* of the corresponding *GET /esx/settings/clusters/{cluster}/vms/solutions* operation.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Solutions** | [**Dictionary&lt;string, EsxSettingsClustersVmsSolutionsSolutionInfo&gt;**](EsxSettingsClustersVmsSolutionsSolutionInfo.md) | Map of solution identifiers to their desired specification.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.vms.SystemVmSolution&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.vms.SystemVmSolution&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

