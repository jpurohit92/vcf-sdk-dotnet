# Vcenter.Automation.OpenApi.Model.EsxSettingsHostsSoftwareCheckResult
The Esx.Settings.Hosts.Software.CheckResult schema contains properties that describe aggregated status of all checks performed.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Aggregated status from all checks performed.  Possible values:   - &#x60;OK&#x60;: The check indicates a success.   - &#x60;WARNING&#x60;: The check indicates a warning.   - &#x60;TIMEOUT&#x60;: The check did not return in a timely manner.   - &#x60;ERROR&#x60;: The check indicates an error.   - &#x60;RETRY&#x60;: The check failed because of an intermittent error, for example a service is overloaded. The client can choose to retry the health check before considering the check as failed.   For more information see: *Esx.Settings.Hosts.Software.Status*.  This property was added in __vSphere API 8.0.0.1__. | 
**StartTime** | **DateTime** | Time when the operation started.  This property was added in __vSphere API 8.0.0.1__. | 
**EndTime** | **DateTime** | Time when the operation completed.  This property was added in __vSphere API 8.0.0.1__. | 
**Commit** | **string** | The identifier of the commit on which checks have been run.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. | 
**HostInfo** | [**EsxSettingsHostInfo**](EsxSettingsHostInfo.md) | Information about the host for which checks have been requested to be run.  This property was added in __vSphere API 8.0.0.1__. | 
**EntityResult** | [**EsxSettingsHostsSoftwareEntityCheckResult**](EsxSettingsHostsSoftwareEntityCheckResult.md) | List of Esx.Settings.Hosts.Software.EntityCheckResult for all entities for which checks have been run.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

