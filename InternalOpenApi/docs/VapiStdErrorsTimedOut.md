# Vcenter.Automation.OpenApi.Model.VapiStdErrorsTimedOut
The Vapi.Std.Errors.TimedOut error indicates that the operation did not complete within the allowed amount of time. The allowed amount of time might be:     - provided by the client as an input parameter.     - a fixed limit of the resource implementation that is a documented part of the contract of the resource.     - a configurable limit used by the implementation of the resource.     - a dynamic limit computed by the implementation of the resource.    The operation may or may not complete after the Vapi.Std.Errors.TimedOut error was reported.    Examples:     - The operation was unable to complete within the timeout duration specified by a parameter of the operation.       Counterexamples:     - A server implementation that puts requests into a queue before dispatching them might delete a request from the queue if it doesn't get dispatched within *n* minutes. The *Vapi.Std.Errors.ServiceUnavailable* error would be used instead.   

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

