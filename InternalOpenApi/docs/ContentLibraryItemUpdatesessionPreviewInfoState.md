# Vcenter.Automation.OpenApi.Model.ContentLibraryItemUpdatesessionPreviewInfoState
The Content.Library.Item.Updatesession.PreviewInfo.State enumerated type defines the state of the update session's preview.  Possible values:   - `UNAVAILABLE`: There are no files in the update session OR a preview is not possible for the files currently in the update session. However, preview may be possible after metadata files such as OVF descriptor are added to the session. In this case the state will transition to PREPARING.   - `NOT_APPLICABLE`: Preview is not possible for this update session. This state is reached when there are no metadata files in the update session and user invokes a session complete operation.   - `PREPARING`: A preview is being prepared for the files currently in the update session. This state is reached when the applicable metadata files are added to the update session but their content is not fully uploaded yet. For OVF item type, this state indicates that the OVF descriptor file is currently being uploaded.   - `AVAILABLE`: Preview is available for this update session. It is possible to review certificate details and warnings, if any. This state is reached when the applicable metadata files in the session have been fully uploaded.   This enumeration was added in __vSphere API 6.8__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

