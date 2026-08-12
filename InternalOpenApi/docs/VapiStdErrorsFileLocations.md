# Vcenter.Automation.OpenApi.Model.VapiStdErrorsFileLocations
The Vapi.Std.Errors.FileLocations schema identifies the file(s) that caused the operation to report the error.    Some types of errors are caused by a problem with one or more files. This schema is intended to be used as the payload to identify those files when the operation reports errors like *Vapi.Std.Errors.NotFound*. See *Vapi.Std.Errors.Error.data*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Primary** | **string** | String identifying the file that triggered the error. | 
**Secondary** | **List&lt;string&gt;** | List (possibly empty) of strings identifying other files that caused the primary file to trigger the error. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

