# Vcenter.Automation.OpenApi.Model.EsxSettingsRepositorySoftwareRecord
The Esx.Settings.Repository.Software.Record schema contains properties to describe details regarding a software specification in the repository.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the software specification.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.repository.software_spec&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.repository.software_spec&#x60;. | 
**DisplayName** | **string** | Display name of the software specification. The returned name is UTF-8 encoded.  This property was added in __vSphere API 9.0.0.0__. | 
**Type** | **string** | The software specification type (Single or Composite).  Possible values:   - &#x60;SINGLE&#x60;: A software specification of this type contains only one image (default image).   - &#x60;COMPOSITE&#x60;: A software specification of this type contains one default image and one or more alternative images.   For more information see: *Esx.Settings.Repository.Software.SoftwareType*.  This property was added in __vSphere API 9.0.0.0__. | 
**SoftwareInfo** | [**EsxSettingsSoftwareInfo**](EsxSettingsSoftwareInfo.md) | Software information associated with the software specification.  This property was added in __vSphere API 9.0.0.0__. | 
**SoftwareSpec** | [**EsxSettingsSoftwareSpec**](EsxSettingsSoftwareSpec.md) | Software specification details.  This property was added in __vSphere API 9.0.0.0__. | 
**AssignedEntities** | [**EsxSettingsRepositorySoftwareAssignedEntities**](EsxSettingsRepositorySoftwareAssignedEntities.md) | Entities that have this software specification assigned.  This property was added in __vSphere API 9.0.0.0__. | 
**Editable** | **bool** | If set to true, this software specification can be edited.  This property was added in __vSphere API 9.0.0.0__. | 
**CreationTime** | **DateTime** | Timestamp describing when this software specification was created.  This property was added in __vSphere API 9.0.0.0__. | 
**ModifiedTime** | **DateTime** | Timestamp describing when this software specification was last modified. This timestamp is updated when the #update API is called or when a draft of this software specification is committed.  This property was added in __vSphere API 9.0.0.0__. | 
**OrchestratorInfo** | [**EsxSettingsOrchestratorInfo**](EsxSettingsOrchestratorInfo.md) | Orchestrator information of the software specification in the repository.  This property was added in __vSphere API 9.0.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**ImageHash** | **string** | The SHA-256 hash of this software specification.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

