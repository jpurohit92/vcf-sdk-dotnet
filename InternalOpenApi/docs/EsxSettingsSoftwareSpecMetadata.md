# Vcenter.Automation.OpenApi.Model.EsxSettingsSoftwareSpecMetadata
The Esx.Settings.SoftwareSpecMetadata schema contains information about the software specification in the repository that is associated to the cluster or host.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Display name of the software specification.  This property was added in __vSphere API 9.0.0.0__. | 
**SoftwareSpecId** | **string** | ID of a software specification from the repository.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.repository.software_spec&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.repository.software_spec&#x60;. | 
**OrchestratorInfo** | [**EsxSettingsOrchestratorInfo**](EsxSettingsOrchestratorInfo.md) | Orchestrator information for the desired state of host or cluster.  This property was added in __vSphere API 9.0.0.0__. | 
**Notifications** | [**EsxSettingsNotifications**](EsxSettingsNotifications.md) | Notifications for the software specification in the repository that is associated with the cluster or host. The owner and owner data are fetched from the desired state of the cluster or host.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

