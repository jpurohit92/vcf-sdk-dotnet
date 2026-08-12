# Vcenter.Automation.OpenApi.Model.EsxSettingsHostsSoftwareStageSpec
The Esx.Settings.Hosts.Software.StageSpec schema contains properties that describe the specification to be used for staging the desired software document to a host.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Commit** | **string** | The minimum commit identifier of the desired software document to be used during the *POST /esx/settings/hosts/{host}/software?action&#x3D;stage* operation.  This property was added in __vSphere API 8.0.0.1__.  if missing or &#x60;null&#x60; or empty the stage operation will use the latest commit to fetch the desired state document.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

