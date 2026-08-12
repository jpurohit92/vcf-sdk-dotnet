# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationReportsRecentTasksInfo
The Esx.Settings.Clusters.Configuration.Reports.RecentTasks.Info schema contains properties that specify the ID of the latest task to be executed for various operations. If a task is currently running, that ID will be returned, otherwise the most recently finished task will be returned.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CheckCompliance** | **string** | The ID of the last check-compliance task to be executed.  This property was added in __vSphere API 8.0.1.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. | [optional] 
**Precheck** | **string** | The ID of the last precheck task to be executed.  This property was added in __vSphere API 8.0.1.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. | [optional] 
**DraftTasks** | [**Dictionary&lt;string, EsxSettingsClustersConfigurationReportsRecentTasksDraftTasks&gt;**](EsxSettingsClustersConfigurationReportsRecentTasksDraftTasks.md) | Map of draft IDs to the latest tasks executed for that draft.  This property was added in __vSphere API 8.0.1.0__.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.esx.settings.draft&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.esx.settings.draft&#x60;. | 
**Apply** | **string** | The ID of the last apply task to be executed.  This property was added in __vSphere API 8.0.1.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.cis.task&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

