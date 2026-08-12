# Vcenter.Automation.OpenApi.Model.VapiStdErrorsUnverifiedPeer
The Vapi.Std.Errors.UnverifiedPeer error indicates that an attempt to connect to an unknown or not-yet-trusted endpoint failed because the system was unable to verify the identity of the endpoint.    Typically the *Vapi.Std.Errors.Error.data* property of this error will contain information that can be presented to a human to allow them to decide whether to trust the endpoint. If they decide to trust the endpoint, the request can be resubmitted with an indication that the endpoint should be trusted.    Examples:     - The client provides an IP address or URL of an endpoint the system should communicate with using an SSL connection, but the endpoint's SSL certificate is self-signed, expired, or otherwise not trustworthy.     - The client provides an IP address of a host the system should communicate with using ssh, but ssh doesn't recognize the public key of the host       This schema was added in __vSphere API 6.7.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

