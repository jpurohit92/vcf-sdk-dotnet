# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareSolutionsUpdateSolutionsSpec
The Esx.Settings.Clusters.Software.Solutions.UpdateSolutionsSpec schema contains properties that describe solutions registered in the software specification.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Solutions** | [**Dictionary&lt;string, EsxSettingsSolutionSpec&gt;**](EsxSettingsSolutionSpec.md) | Mapping from solution identifier to the solution specification. The key is the solution name and the value is the specification detailing components registered by that solution.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.solution&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.solution&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

