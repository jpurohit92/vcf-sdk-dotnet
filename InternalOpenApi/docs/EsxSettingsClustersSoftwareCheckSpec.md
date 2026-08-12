# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareCheckSpec
The Esx.Settings.Clusters.Software.CheckSpec schema contains properties that describe the specification to be used for running checks on the cluster before the *POST /esx/settings/clusters/{cluster}/software?action=apply* operation.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Commit** | **string** | The minimum commit identifier of the desired software document to be used during the check operation.  This property was added in __vSphere API 7.0.0.0__.  if missing or &#x60;null&#x60; or empty the check operation will use the latest commit to fetch the desired state document.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. | [optional] 
**Hosts** | **List&lt;string&gt;** | The specific hosts for which checks need to be performed  This property was added in __vSphere API 7.0.0.0__.  if missing or &#x60;null&#x60; or empty checks are run for all hosts within the cluster.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;HostSystem&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

