# Vcenter.ViJson.OpenApi.Model.ScanHostPatchRequestType
The parameters of *HostPatchManager.ScanHostPatch_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Repository** | [**HostPatchManagerLocator**](HostPatchManagerLocator.md) | Location of the repository that contains the bulletin depot. The depot must be organized as a flat collection of bulletins with each one being a folder named after the bulletin ID. Each folder must contain the full update metadata.  | 
**UpdateID** | **List&lt;string&gt;** | The updates to scan. Wildcards can be used to specify the update IDs. The wildcards will be expanded to include all updates whose IDs match the specified wildcard and whose metadata is available in the repository. Specifying no update is equivalent to a wildcard \&quot;\\*\&quot;. In this case all updates available in the repository will be scanned.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

