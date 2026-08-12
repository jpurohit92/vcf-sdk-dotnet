# Vcenter.Automation.OpenApi.Model.VcenterGuestCloudConfiguration
Guest customization settings to customize a guest operating system with cloud configuration.    The Vcenter.Guest.CloudConfiguration schema contains the type of cloud configuration and the settings of that cloud configuration.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of the cloud configuration.  Possible values:   - &#x60;CLOUDINIT&#x60;: cloud-init configuration   For more information see: *Vcenter.Guest.CloudConfiguration.Type*.  This property was added in __vSphere API 7.0.3.0__. | 
**Cloudinit** | [**VcenterGuestCloudinitConfiguration**](VcenterGuestCloudinitConfiguration.md) | cloud-init configuration  This property was added in __vSphere API 7.0.3.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.Guest.CloudConfiguration.Type.CLOUDINIT*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

