# Vcenter.Automation.OpenApi.Model.EsxSettingsRepositorySoftwareDraftsImportSpec
The Esx.Settings.Repository.Software.Drafts.ImportSpec schema defines the information used to import the desired software specification into the repository.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | Display name for the draft created.  This property was added in __vSphere API 9.0.0.0__. | 
**SourceType** | **string** | Type of the source to import the desired software specification  Possible values:   - &#x60;PULL&#x60;: Content is pulled from the URL location. The URL scheme of the value in #pullLocation can be http, https or file.   - &#x60;PUSH&#x60;: Content was previously uploaded using the file upload endpoint present on vCenter appliance. This endpoint is present at https://VCENTERFQDN:9087/vum-fileupload URL.   - &#x60;JSON_STRING&#x60;: The string representing the content of the software specification.   For more information see: *Esx.Settings.Repository.Software.Drafts.SourceType*.  This property was added in __vSphere API 9.0.0.0__. | 
**Location** | **string** | Location of the software specification file to be imported.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of source_type is *Esx.Settings.Repository.Software.Drafts.SourceType.PULL*. | [optional] 
**FileId** | **string** | File identifier returned by the file upload endpoint after file is uploaded.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of source_type is *Esx.Settings.Repository.Software.Drafts.SourceType.PUSH*. | [optional] 
**SoftwareSpec** | **string** | The JSON string representing the desired software specification.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of source_type is *Esx.Settings.Repository.Software.Drafts.SourceType.JSON_STRING*. | [optional] 
**DeleteExistingDraft** | **bool** | Deletes any existing draft by the user before creating a new draft, if deleteExistingDraft is set to TRUE.  This property was added in __vSphere API 9.0.0.0__.  If deleteExistingDraft is either unset of set to FALSE and there is already draft created by the user, an &#x60;AlreadyExists&#x60; exception is thrown. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

