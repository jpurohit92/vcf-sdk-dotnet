# Vcenter.Automation.OpenApi.Model.VcenterGuestConfigurationSpec
The Vcenter.Guest.ConfigurationSpec schema specifies the settings for customizing a guest operating system.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WindowsConfig** | [**VcenterGuestWindowsConfiguration**](VcenterGuestWindowsConfiguration.md) | Guest customization specification for a Windows guest operating system  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, *Vcenter.Guest.ConfigurationSpec.linux_config* or *Vcenter.Guest.ConfigurationSpec.cloud_config* must be set. Otherwise, an appropriate fault will be thrown. | [optional] 
**LinuxConfig** | [**VcenterGuestLinuxConfiguration**](VcenterGuestLinuxConfiguration.md) | Guest customization specification for a linux guest operating system  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, *Vcenter.Guest.ConfigurationSpec.windows_config* or *Vcenter.Guest.ConfigurationSpec.cloud_config* must be set. Otherwise, an appropriate fault will be thrown. | [optional] 
**CloudConfig** | [**VcenterGuestCloudConfiguration**](VcenterGuestCloudConfiguration.md) | Guest customization specification with cloud configuration.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, *Vcenter.Guest.ConfigurationSpec.windows_config* or *Vcenter.Guest.ConfigurationSpec.linux_config* must be set. Otherwise, an appropriate fault will be thrown. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

