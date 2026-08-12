# Vcenter.Automation.OpenApi.Model.EsxSettingsRepositorySoftwareCopySpec
The Esx.Settings.Repository.Software.CopySpec schema contains properties that are used to create a draft based on an existing software specification in the repository.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteExistingDraft** | **bool** | Deletes any existing draft by the user before creating a new draft, if deleteExistingDraft is set to TRUE.  This property was added in __vSphere API 9.0.0.0__.  If deleteExistingDraft is either unset of set to FALSE and there is already draft created by the user, an &#x60;AlreadyExists&#x60; exception is thrown. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

