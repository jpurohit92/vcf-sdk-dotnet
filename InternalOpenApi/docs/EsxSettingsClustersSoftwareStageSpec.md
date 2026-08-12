# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersSoftwareStageSpec
The Esx.Settings.Clusters.Software.StageSpec schema contains properties that describe the specification to be used for staging the desired software document to a cluster.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Commit** | **string** | The minimum commit identifier of the desired software document to be used during the *POST /esx/settings/clusters/{cluster}/software?action&#x3D;stage* operation.  This property was added in __vSphere API 8.0.0.1__.  if missing or &#x60;null&#x60; or empty the stage operation will use the latest commit to fetch the desired state document.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. | [optional] 
**Hosts** | **List&lt;string&gt;** | The specific hosts within the cluster to be considered during the *POST /esx/settings/clusters/{cluster}/software?action&#x3D;stage* operation.  This property was added in __vSphere API 8.0.0.1__.  if missing or &#x60;null&#x60; or empty the *POST /esx/settings/clusters/{cluster}/software?action&#x3D;stage* operation will stage all hosts within the cluster.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;HostSystem&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

