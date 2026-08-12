# Vcenter.Automation.OpenApi.Model.ContentLibraryStateInfoState
The Content.Library.StateInfo.State enumerated type defines the state of a LibraryModel.    The state of a library can be used to determine if the library is in maintenance or not. A *Content.Library* can be moved to *Content.Library.StateInfo.State.MAINTENANCE* in the following cases.     -  *POST /content/library/{libraryId}?action=migrate*     -  enterMaintenance in *Content.Library*     Possible values:   - `ACTIVE`: This is default library state when library is created. The library is fully functional when in this state.   - `MAINTENANCE`: This state indicates that the library is in maintenance. Any operations that alter the Library content or its use are restricted.   This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

