# Vcenter.ViJson.OpenApi.Model.InstallHostPatchRequestType
The parameters of *HostPatchManager.InstallHostPatch_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Repository** | [**HostPatchManagerLocator**](HostPatchManagerLocator.md) | Location of the repository that contains the bulletin depot. The depot must be organized as a flat collection of bulletins with each one being a folder named after the bulletin ID. Each folder must contain both update metadata and required binaries.  | 
**UpdateID** | **string** | The update to be installed on the host.  | 
**Force** | **bool** | Specify whether to force reinstall an update. By default, installing an already-installed update would fail with the *PatchAlreadyInstalled* fault. If force is set to true, the update will be forcefully reinstalled, thus overwriting the already installed update.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

