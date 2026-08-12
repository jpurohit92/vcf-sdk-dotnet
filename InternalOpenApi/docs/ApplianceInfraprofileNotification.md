# Vcenter.Automation.OpenApi.Model.ApplianceInfraprofileNotification
The Appliance.Infraprofile.Notification schema contains properties to describe any info/warning/error messages that Tasks can raise.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Notification** | **string** | The notification id.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.infraprofile.notification&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.infraprofile.notification&#x60;. | 
**Time** | **DateTime** | The time the notification was raised/found.  This property was added in __vSphere API 7.0.0.0__.  Only set if the time information is available. | [optional] 
**Message** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | The notification message.  This property was added in __vSphere API 7.0.0.0__. | 
**Resolution** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | The resolution message, if any.  This property was added in __vSphere API 7.0.0.0__.  Only set for warnings and errors. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

