# Vcenter.Automation.OpenApi.Model.ApplianceTlsManualParametersServicesListItem
The Appliance.Tls.ManualParameters.Services.ListItem schema contains the information about the service.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Service** | **string** | Defines the TLS integrated service.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.appliance.tls.manual_parameters.services&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.appliance.tls.manual_parameters.services&#x60;. | 
**Info** | [**ApplianceTlsManualParametersServicesInfo**](ApplianceTlsManualParametersServicesInfo.md) | Contains information about the TLS configurations of a specific service.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, there is no specific configuration for that service. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

