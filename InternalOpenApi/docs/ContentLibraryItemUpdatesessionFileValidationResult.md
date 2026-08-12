# Vcenter.Automation.OpenApi.Model.ContentLibraryItemUpdatesessionFileValidationResult
The Content.Library.Item.Updatesession.File.ValidationResult schema defines the result of validating the files in the session.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HasErrors** | **bool** | Whether the validation was succesful or not. In case of errors, the *Content.Library.Item.Updatesession.File.ValidationResult.missing_files* and *Content.Library.Item.Updatesession.File.ValidationResult.invalid_files* will contain at least one entry. | 
**MissingFiles** | **List&lt;string&gt;** | A set containing the names of the files that are required but the client hasn&#39;t added. | 
**InvalidFiles** | [**List&lt;ContentLibraryItemUpdatesessionFileValidationError&gt;**](ContentLibraryItemUpdatesessionFileValidationError.md) | A list containing the files that have been identified as invalid and details about the error. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

