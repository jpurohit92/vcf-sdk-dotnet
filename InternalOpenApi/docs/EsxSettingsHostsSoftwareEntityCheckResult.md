# Vcenter.Automation.OpenApi.Model.EsxSettingsHostsSoftwareEntityCheckResult
The Esx.Settings.Hosts.Software.EntityCheckResult schema contains properties that describe aggregated status of all checks performed on a specific entity.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The entity type for which these checks are being run.  Possible values:   - &#x60;HOST&#x60;: Entity type Host   For more information see: *Esx.Settings.Hosts.Software.EntityCheckResult.EntityType*.  This property was added in __vSphere API 8.0.0.1__. | 
**Host** | **string** | If the entity type is HOST then the host identifier for which the checks have been run.  This property was added in __vSphere API 8.0.0.1__.  This property is optional and it is only relevant when the value of type is *Esx.Settings.Hosts.Software.EntityCheckResult.EntityType.HOST*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;HostSystem&#x60;. | [optional] 
**Status** | **string** | Aggregated status from all checks performed on this entity.  Possible values:   - &#x60;OK&#x60;: The check indicates a success.   - &#x60;WARNING&#x60;: The check indicates a warning.   - &#x60;TIMEOUT&#x60;: The check did not return in a timely manner.   - &#x60;ERROR&#x60;: The check indicates an error.   - &#x60;RETRY&#x60;: The check failed because of an intermittent error, for example a service is overloaded. The client can choose to retry the health check before considering the check as failed.   For more information see: *Esx.Settings.Hosts.Software.Status*.  This property was added in __vSphere API 8.0.0.1__. | 
**CheckStatuses** | [**List&lt;EsxSettingsHostsSoftwareCheckStatus&gt;**](EsxSettingsHostsSoftwareCheckStatus.md) | List of Esx.Settings.Hosts.Software.CheckStatus for all checks performed.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

