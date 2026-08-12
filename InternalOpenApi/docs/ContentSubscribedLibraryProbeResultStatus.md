# Vcenter.Automation.OpenApi.Model.ContentSubscribedLibraryProbeResultStatus
The Content.SubscribedLibrary.ProbeResult.Status enumerated type defines the error status constants for the probe result.  Possible values:   - `SUCCESS`: Indicates that the probe was successful.   - `INVALID_URL`: Indicates that the supplied URL was not valid.   - `TIMED_OUT`: Indicates that the probe timed out while attempting to connect to the URL.   - `HOST_NOT_FOUND`: Indicates that the host in the URL could not be found.   - `RESOURCE_NOT_FOUND`: Indicates that the given resource at the URL was not found.   - `INVALID_CREDENTIALS`: Indicates that the connection was rejected due to invalid credentials.   - `CERTIFICATE_ERROR`: Indicates that the provided server certificate in *Content.Library.SubscriptionInfo.ssl_thumbprint* is invalid. In this case, the returned #sslThumbprint should be set in *Content.Library.SubscriptionInfo.ssl_thumbprint*.   - `UNKNOWN_ERROR`: Indicates an unspecified error different from the other error cases defined in *Content.SubscribedLibrary.ProbeResult.Status*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

