# Vcenter.Automation.OpenApi.Model.ApplianceUpdateServiceInfo
The Appliance.Update.ServiceInfo schema describes a service to be stopped and started during the update installation.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Service** | **string** | Service ID  This property was added in __vSphere API 6.7__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.appliance.service&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.appliance.service&#x60;. | 
**Description** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Service description  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

