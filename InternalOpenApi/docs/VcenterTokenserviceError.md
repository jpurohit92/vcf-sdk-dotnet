# Vcenter.Automation.OpenApi.Model.VcenterTokenserviceError
The Vcenter.Tokenservice.Error error describes theproperties common to all standard errors.    This error serves two purposes:     1. It is the error that clients in many programming languages can catch to handle all standard errors. Typically those clients will display one or more of the localizable messages from *Vcenter.Tokenservice.Error.messages* to a human.     2. It is the error that operations can report when they need to report some error, but the error doesn't fit into any other standard error, and in fact the only reasonable way for a client to react to the error is to display the message(s) to a human.   

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Messages** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | Stack of one or more localizable messages for human error consumers.    The message at the top of the stack (first in the list) describes the error from the perspective of the operation the client invoked. Each subsequent message in the stack describes the \&quot;cause\&quot; of the prior message. | 
**Data** | **Object** | Data to facilitate clients responding to the operation reporting a standard error to indicating that it was unable to complete successfully.    Operations may provide data that clients can use when responding to errors. Since the data that clients need may be specific to the context of the operation reporting the error, different operations that report the same error may provide different data in the error. The documentation for each each operation will describe what, if any, data it provides for each error it reports. The ArgumentLocations, FileLocations, and TransientIndication schemas are intended as possible values for this property. *Vapi.Std.DynamicID* may also be useful as a value for this property (although that is not its primary purpose). Some resources may provide their own specific schemas for use as the value of this property when reporting errors from their operations.  Some operations will not set this property when reporting errors. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

