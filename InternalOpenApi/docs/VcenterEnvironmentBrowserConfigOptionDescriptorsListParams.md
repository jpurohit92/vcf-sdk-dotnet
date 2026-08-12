# Vcenter.Automation.OpenApi.Model.VcenterEnvironmentBrowserConfigOptionDescriptorsListParams
The Vcenter.EnvironmentBrowser.ConfigOptionDescriptors.ListParams schema specifies the parameters for the *GET /vcenter/environment-browser/config-option-descriptors* operation, such as which clusters to query.  This schema was added in __vSphere API 8.0.2.00300__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Clusters** | **List&lt;string&gt;** | A set of Cluster IDs that specify for which Clusters the configuration option descriptors are requested.  This property was added in __vSphere API 8.0.2.00300__.  if missing or &#x60;null&#x60; or empty an error will be returned. Ability to pass unset value is left for future expansion.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

