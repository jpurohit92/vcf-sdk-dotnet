# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationHostPrecheckResult
This Esx.Settings.Clusters.Configuration.HostPrecheckResult schema contains properties that describes the Precheck API result on a host.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | [**EsxSettingsClustersConfigurationHostStatus**](EsxSettingsClustersConfigurationHostStatus.md) | This field represents the status of the precheck request for this host. {link HostStatus#status} is ERROR or SKIPPED, if precheck was not completed on the host due to some error or if health checks failed. If precheck failed due to host validation errors, details are specified in *Esx.Settings.Clusters.Configuration.HostPrecheckResult.validation_errors*. If precheck failed due to generic error, details are specified in the *Esx.Settings.Clusters.Configuration.HostPrecheckResult.summary*. Health check result is specified in *Esx.Settings.Clusters.Configuration.HostPrecheckResult.precheck_result*.  This property was added in __vSphere API 8.0.1.0__. | 
**Summary** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Summarizing precheck operation on the host.  This property was added in __vSphere API 8.0.1.0__. | 
**ValidationErrors** | [**List&lt;EsxSettingsClustersConfigurationValidationError&gt;**](EsxSettingsClustersConfigurationValidationError.md) | This field represents the validation errors if the desired configuration specified is not valid.  This property was added in __vSphere API 8.0.1.0__.  This field is set if #HostStatus#status is ERROR due to host returning validation errors. | [optional] 
**Impact** | [**EsxSettingsClustersConfigurationImpactInfo**](EsxSettingsClustersConfigurationImpactInfo.md) | This field represents the impact on the host to reach the desired configuration state.  This property was added in __vSphere API 8.0.1.0__.  This field is set if there are no validation errors on the host. The *Esx.Settings.Clusters.Configuration.HostStatus.status* may be OK or ERROR. | [optional] 
**PrecheckResult** | [**EsxSettingsStatusInfo**](EsxSettingsStatusInfo.md) | This field represents the health check results from the host, if the host needs to be put in maintenance mode or to be rebooted.  This property was added in __vSphere API 8.0.1.0__.  This field is set if there are not validation errors and health checks are run on the host. The *Esx.Settings.Clusters.Configuration.HostStatus.status* may be OK or ERROR. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

