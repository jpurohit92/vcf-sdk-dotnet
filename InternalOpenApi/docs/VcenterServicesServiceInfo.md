# Vcenter.Automation.OpenApi.Model.VcenterServicesServiceInfo
The Vcenter.Services.Service.Info schema contains information about a service.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NameKey** | **string** | Service name key. Can be used to lookup resource bundle  This property was added in __vSphere API 6.7__. | 
**DescriptionKey** | **string** | Service description key. Can be used to lookup resource bundle  This property was added in __vSphere API 6.7__. | 
**StartupType** | **string** | Startup Type.  Possible values:   - &#x60;MANUAL&#x60;: Service Startup type is Manual, thus issuing an explicit start on the service will start it.   - &#x60;AUTOMATIC&#x60;: Service Startup type is Automatic, thus during starting all services or issuing explicit start on the service will start it.   - &#x60;DISABLED&#x60;: Service Startup type is Disabled, thus it will not start unless the startup type changes to manual or automatic.   For more information see: *Vcenter.Services.Service.StartupType*.  This property was added in __vSphere API 6.7__. | 
**State** | **string** | Running State.  Possible values:   - &#x60;STARTING&#x60;: Service Run State is Starting, it is still not functional   - &#x60;STOPPING&#x60;: Service Run State is Stopping, it is not functional   - &#x60;STARTED&#x60;: Service Run State is Started, it is fully functional   - &#x60;STOPPED&#x60;: Service Run State is Stopped   For more information see: *Vcenter.Services.Service.State*.  This property was added in __vSphere API 6.7__. | 
**Health** | **string** | Health of service.  Possible values:   - &#x60;DEGRADED&#x60;: Service is in degraded state, it is not functional.   - &#x60;HEALTHY&#x60;: Service is in a healthy state and is fully functional.   - &#x60;HEALTHY_WITH_WARNINGS&#x60;: Service is healthy with warnings.   For more information see: *Vcenter.Services.Service.Health*.  This property was added in __vSphere API 6.7__.  This property is optional and it is only relevant when the value of state is *Vcenter.Services.Service.State.STARTED*. | [optional] 
**HealthMessages** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | Localizable messages associated with the health of the service  This property was added in __vSphere API 6.7__.  This property is optional and it is only relevant when the value of state is *Vcenter.Services.Service.State.STARTED*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

