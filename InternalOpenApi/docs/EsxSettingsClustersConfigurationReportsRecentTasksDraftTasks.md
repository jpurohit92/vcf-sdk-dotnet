# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationReportsRecentTasksDraftTasks
The Esx.Settings.Clusters.Configuration.Reports.RecentTasks.DraftTasks schema contains properties that specify the ID of the latest task to be executed for various operations on a draft.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Precheck** | **string** | The ID of the last precheck task to be executed for this draft.  This property was added in __vSphere API 8.0.1.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

