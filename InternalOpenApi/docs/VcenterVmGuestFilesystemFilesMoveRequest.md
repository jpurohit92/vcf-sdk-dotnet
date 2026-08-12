# Vcenter.Automation.OpenApi.Model.VcenterVmGuestFilesystemFilesMoveRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Credentials** | [**VcenterVmGuestCredentials**](VcenterVmGuestCredentials.md) |  | 
**Path** | **string** | The complete path to the original file or symbolic link to be moved. | 
**NewPath** | **string** | The complete path to the new file. It cannot be a path to an existing directory. | 
**Overwrite** | **bool** | If true, the destination file is overwritten.  If missing or &#x60;null&#x60;, the destination file is not overwritten. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

