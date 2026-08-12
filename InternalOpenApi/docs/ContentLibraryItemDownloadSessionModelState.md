# Vcenter.Automation.OpenApi.Model.ContentLibraryItemDownloadSessionModelState
The state of the download session.  Possible values:   - `ACTIVE`: The session is active. Individual files may be in the process of being transferred and may become ready for download at different times.   - `CANCELED`: The session has been canceled. On-going downloads may fail. The session will stay in this state until it is either deleted by the user or automatically cleaned up by the Content Library Service.   - `ERROR`: Indicates there was an error during the session lifecycle. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

