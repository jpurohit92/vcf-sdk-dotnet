# Vcenter.Automation.OpenApi.Model.EsxSettingsRepositorySoftwareDraftsFilterSpec
The Esx.Settings.Repository.Software.Drafts.FilterSpec schema contains properties used to filter the results when listing software drafts. See *GET /esx/settings/repository/software/drafts*.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SoftwareSpecIds** | **List&lt;string&gt;** | Software specification identifier for which the draft is created. If the software specification identifier is set to -1, global software drafts are returned.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; or empty, drafts from all software specification identifiers are returned.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.esx.settings.repository.software_spec&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.esx.settings.repository.software_spec&#x60;. | [optional] 
**Owners** | **List&lt;string&gt;** | Owners of the drafts.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; or empty, drafts from all owners will be returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

