# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsSolutionsFilterSpec
The Esx.Settings.Clusters.Vms.Solutions.FilterSpec schema contains properties that are used to filter the desired specification that to be returned. See *GET /esx/settings/clusters/{cluster}/vms/solutions*.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Solutions** | **List&lt;string&gt;** | Solutions to return desired specification for.  This property was added in __vSphere API 9.0.0.0__.  if missing or &#x60;null&#x60; or empty the desired specification of all solutions in the cluster to be returned.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.esx.settings.vms.SystemVmSolution&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.esx.settings.vms.SystemVmSolution&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

