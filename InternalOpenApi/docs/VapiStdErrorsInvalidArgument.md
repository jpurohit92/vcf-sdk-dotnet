# Vcenter.Automation.OpenApi.Model.VapiStdErrorsInvalidArgument
The Vapi.Std.Errors.InvalidArgument error indicates that the values received for one or more parameters are not acceptable.    This error is reported by the API infrastructure, so it could occur in response to the invocation of any operation. It may also be reported as the result of operation-specific validation.    Examples:     - A parameter has a value that is not of the expected type.     - A parameter has a value that is not in the required range.     - A parameter has a value that is not one of the specifically allowed strings.     - One property of a schema is the tag for a tagged union, and has a specific value but another property of the schema that is required to be specified when the tag has that value is not specified, or another property of the schema that is required to be unspecified when the tag has that value is specified.       Counterexamples:     - Trying to create a new tag in tag category when a tag with the specified name already exists the tag category. The *Vapi.Std.Errors.AlreadyExists* error would be used instead.     - Invoke the operation to retrieve information about a virtual machine, passing an id that does not identify an existing virtual machine. The *Vapi.Std.Errors.NotFound* error would be used instead.     - Attempt to put a virtual machine into a folder that can only contain hosts. The *Vapi.Std.Errors.InvalidElementType* error would be used instead.     - Attempt to attach a SCSI virtual disk to an IDE port. The *Vapi.Std.Errors.InvalidElementType* error would be used instead.   

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

