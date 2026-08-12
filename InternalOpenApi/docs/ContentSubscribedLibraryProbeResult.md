# Vcenter.Automation.OpenApi.Model.ContentSubscribedLibraryProbeResult
The Content.SubscribedLibrary.ProbeResult schema defines the subscription information probe result. This describes whether using a given subscription URL is successful or if there are access problems, such as SSL errors.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status of probe result. This will be one of Status.  Possible values:   - &#x60;SUCCESS&#x60;: Indicates that the probe was successful.   - &#x60;INVALID_URL&#x60;: Indicates that the supplied URL was not valid.   - &#x60;TIMED_OUT&#x60;: Indicates that the probe timed out while attempting to connect to the URL.   - &#x60;HOST_NOT_FOUND&#x60;: Indicates that the host in the URL could not be found.   - &#x60;RESOURCE_NOT_FOUND&#x60;: Indicates that the given resource at the URL was not found.   - &#x60;INVALID_CREDENTIALS&#x60;: Indicates that the connection was rejected due to invalid credentials.   - &#x60;CERTIFICATE_ERROR&#x60;: Indicates that the provided server certificate in *Content.Library.SubscriptionInfo.ssl_thumbprint* is invalid. In this case, the returned #sslThumbprint should be set in *Content.Library.SubscriptionInfo.ssl_thumbprint*.   - &#x60;UNKNOWN_ERROR&#x60;: Indicates an unspecified error different from the other error cases defined in *Content.SubscribedLibrary.ProbeResult.Status*.   For more information see: *Content.SubscribedLibrary.ProbeResult.Status*. | 
**SslThumbprint** | **string** | The SSL thumbprint for the remote endpoint.  A SSL thumbprint is only returned if the host is secured with SSL/TLS. | [optional] 
**SslCertificate** | **string** | The SSL certificate for the remote endpoint.  This property was added in __vSphere API 9.0.0.0__.  A SSL certificate is only returned if the host is secured with SSL/TLS and if the {SubscribedLibrary#sslCertificate} is also set. | [optional] 
**ErrorMessages** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | If the probe result is in an error status, this property will contain the detailed error messages. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

