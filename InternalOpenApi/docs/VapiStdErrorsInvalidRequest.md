# Vcenter.Automation.OpenApi.Model.VapiStdErrorsInvalidRequest
The Vapi.Std.Errors.InvalidRequest error indicates that the request is malformed in such a way that the server is unable to process it.    Examples:     - The XML in a SOAP request is not well-formed so the server cannot parse the request.     - The XML in a SOAP request is well-formed but does not match the structure required by the SOAP specification.     - A JSON-RPC request is not valid JSON.     - The JSON sent in a JSON-RPC request is not a valid JSON-RPC Request object.     - The Request object from a JSON-RPC request does not match the structure required by the API infrastructure.       Counterexamples:     - The parameter has a value that is not with the required range. The *Vapi.Std.Errors.InvalidArgument* error would be used instead.     - The name of the operation specified in the request doesn't not match any known operation. The *Vapi.Std.Errors.NotFound* error would be used instead.       Some transport protocols (for example JSON-RPC) include their own mechanism for reporting these kinds of errors, and the API infrastructure for a programming language may expose the errors using a language specific mechanism, so this error might not be used.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

