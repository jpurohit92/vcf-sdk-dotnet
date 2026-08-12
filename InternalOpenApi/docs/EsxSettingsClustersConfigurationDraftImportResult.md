# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersConfigurationDraftImportResult
The Esx.Settings.Clusters.Configuration.DraftImportResult schema contains properties that describe the result of importing the desired configuration for a cluster into a draft.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Status of importing desired configuration.  Possible values:   - &#x60;RUNNING&#x60;: The task is in-progress.   - &#x60;OK&#x60;: Desired configuration imported successfully.   - &#x60;ERROR&#x60;: Desired configuration import failed with error.   - &#x60;CANCELED&#x60;   For more information see: *Esx.Settings.Clusters.Configuration.DraftImportResult.Status*. | 
**Draft** | **string** | This identifier refers to the commit action of importing the desired configuration document. This identifier can be used in the apply API.  This property is optional and it is only relevant when the value of status is *Esx.Settings.Clusters.Configuration.DraftImportResult.Status.OK*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.esx.settings.draft&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.esx.settings.draft&#x60;. | [optional] 
**Error** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | Localized message describing the error encountered while importing desired configuration. The import operation will fail if the configuration document is an invalid JSON.  This property is optional and it is only relevant when the value of status is *Esx.Settings.Clusters.Configuration.DraftImportResult.Status.ERROR*. | [optional] 
**Warnings** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | Any issues found during the import are reported in this list. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

