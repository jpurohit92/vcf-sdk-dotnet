# Vcenter.Automation.OpenApi.Model.VapiStdErrorsInvalidElementType
The Vapi.Std.Errors.InvalidElementType error indicates that the server was unable to fulfil the request because an element of a specific type cannot be a member of particular group.    This error could be reported, for example, if an attempt is made to put an element into the wrong type of container.    Examples:     - Attempt to put a virtual machine into a folder that can only contain hosts.     - Attempt to attach a SCSI virtual disk to an IDE port.    Counterexamples:     - A parameter has a value that is not of the expected type. The *Vapi.Std.Errors.InvalidArgument* error would be used instead.   

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

