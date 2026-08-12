# Vcenter.ViJson.OpenApi.Model.InstallHostPatchV2RequestType
The parameters of *HostPatchManager.InstallHostPatchV2_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MetaUrls** | **List&lt;string&gt;** | A list of urls pointing to metadata.zip.  | [optional] 
**BundleUrls** | **List&lt;string&gt;** | a list of urls pointing to an \&quot;offline\&quot; bundle. It is not supported in 5.0 or later.  | [optional] 
**VibUrls** | **List&lt;string&gt;** | The urls of update binary files to be installed.  | [optional] 
**Spec** | [**HostPatchManagerPatchManagerOperationSpec**](HostPatchManagerPatchManagerOperationSpec.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

