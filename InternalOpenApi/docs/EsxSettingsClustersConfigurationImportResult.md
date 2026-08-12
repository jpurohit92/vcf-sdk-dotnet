# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationImportResult
This Esx.Settings.Clusters.Configuration.ImportResult schema contains properties that describe the result of importing a configuration document in the cluster.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Possible values:   - &#x60;RUNNING&#x60;: The task is in-progress.   - &#x60;OK&#x60;   - &#x60;ERROR&#x60;   - &#x60;CANCELED&#x60;   For more information see: *Esx.Settings.Clusters.Configuration.ImportResult.Status*.  This property was added in __vSphere API 8.0.1.0__. | 
**Commit** | **string** | This identifier refers to the commit action of importing the desired configuration document. This identifier can be used in the apply API.  This property was added in __vSphere API 8.0.1.0__.  This property is optional and it is only relevant when the value of status is *Esx.Settings.Clusters.Configuration.ImportResult.Status.OK*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. | [optional] 
**Errors** | [**List&lt;EsxSettingsClustersConfigurationValidationError&gt;**](EsxSettingsClustersConfigurationValidationError.md) | Lists all validation errors identified in the configuration document.  This property was added in __vSphere API 8.0.1.0__.  This is set when #success is false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

