# Vcenter.Automation.OpenApi.Model.VapiStdErrorsArgumentLocations
The Vapi.Std.Errors.ArgumentLocations schema describes which part(s) of the input to the operation caused the error.    Some types of errors are caused by the value of one of the inputs to the operation, possibly due to an interaction with other inputs to the operation.    This schema is intended to be used as the payload to identify those inputs when the operation reports errors like *Vapi.Std.Errors.InvalidArgument* or *Vapi.Std.Errors.NotFound*. See *Vapi.Std.Errors.Error.data*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Primary** | **string** | String describing the location of the input that triggered the error. | 
**Secondary** | **List&lt;string&gt;** | List (possibly empty) of strings describing the locations of other inputs that caused the the primary input to trigger the error. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

