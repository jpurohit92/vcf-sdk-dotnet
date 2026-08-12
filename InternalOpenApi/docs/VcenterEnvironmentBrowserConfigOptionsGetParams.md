# Vcenter.Automation.OpenApi.Model.VcenterEnvironmentBrowserConfigOptionsGetParams
The Vcenter.EnvironmentBrowser.ConfigOptions.GetParams schema specifies the parameters for the *GET /vcenter/environment-browser/config-options* operation, such as which clusters to query.  This schema was added in __vSphere API 8.0.2.00300__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigOption** | **string** | Query for a specific config option with the key obtained from *GET /vcenter/environment-browser/config-option-descriptors*.  This property was added in __vSphere API 8.0.2.00300__.  if missing or &#x60;null&#x60; then the default config option will be returned.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.config_option&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.config_option&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

