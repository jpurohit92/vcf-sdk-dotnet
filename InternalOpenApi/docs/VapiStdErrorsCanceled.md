# Vcenter.Automation.OpenApi.Model.VapiStdErrorsCanceled
The Vapi.Std.Errors.Canceled error indicates that the operation canceled itself in response to an explicit request to do so. Operations being \"canceled\" for other reasons (for example the client connection was closed, a time out occured, or due to excessive resource consumption) should not report this error.    Examples:     - A user is monitoring the progress of the operation in a GUI and sees that it is likely to take longer than he is willing to wait and clicks the cancel button.     - A user invokes the operation using a command-line tool and decides that she didn't really want to invoke that operation, and presses CTRL-c.       Counterexamples:     - The client's connection to the server was closed. Reporting an error is pointless since the client will not receive the error response because the connection has been closed.     - The request is taking longer than some amount of time. The *Vapi.Std.Errors.TimedOut* error would be reported if the time was specified as part of the input or is documented in the API contract.   

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

