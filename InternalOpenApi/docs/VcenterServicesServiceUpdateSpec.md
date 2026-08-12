# Vcenter.Automation.OpenApi.Model.VcenterServicesServiceUpdateSpec
The Vcenter.Services.Service.UpdateSpec schema describes the changes to be made to the configuration of the service.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartupType** | **string** | Startup Type  Possible values:   - &#x60;MANUAL&#x60;: Service Startup type is Manual, thus issuing an explicit start on the service will start it.   - &#x60;AUTOMATIC&#x60;: Service Startup type is Automatic, thus during starting all services or issuing explicit start on the service will start it.   - &#x60;DISABLED&#x60;: Service Startup type is Disabled, thus it will not start unless the startup type changes to manual or automatic.   For more information see: *Vcenter.Services.Service.StartupType*.  This property was added in __vSphere API 6.7__.  If unspecified, leaves value unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

