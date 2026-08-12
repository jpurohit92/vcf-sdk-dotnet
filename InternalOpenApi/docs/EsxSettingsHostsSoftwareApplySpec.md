# Vcenter.Automation.OpenApi.Model.EsxSettingsHostsSoftwareApplySpec
The Esx.Settings.Hosts.Software.ApplySpec schema contains properties that describe the specification to be used for applying the desired software document to a host.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Commit** | **string** | The minimum commit identifier of the desired software document to be used during the *POST /esx/settings/hosts/{host}/software?action&#x3D;apply* operation.  This property was added in __vSphere API 8.0.0.1__.  if missing or &#x60;null&#x60; or empty the apply operation will use the latest commit to fetch the desired state document.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.commit&#x60;. | [optional] 
**AcceptEula** | **bool** | Accept the VMware End User License Agreement (EULA) before starting the *POST /esx/settings/hosts/{host}/software?action&#x3D;apply* operation.    The VMware EULA is available for download at, https://www.vmware.com/download/eula.html  This property was added in __vSphere API 8.0.0.1__.  if missing or &#x60;null&#x60; the *POST /esx/settings/hosts/{host}/software?action&#x3D;apply* operation could fail due to the EULA not being accepted. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

