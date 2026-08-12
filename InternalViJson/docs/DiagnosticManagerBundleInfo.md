# Vcenter.ViJson.OpenApi.Model.DiagnosticManagerBundleInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**System** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host to which this diagnostic bundle belongs.  If this is for the default server, then it is not set.  Refers instance of *HostSystem*.  | [optional] 
**Url** | **string** | The location from which the diagnostic bundle can be downloaded.  The host part of the URL is returned as &#39;\\*&#39; if the hostname to be used is the name of the server to which the call was made. For example, if the call is made to vcsrv1.domain1.com, and the bundle is available for download from http://vcsrv1.domain1.com/diagnostics/bundle.zip, the URL returned may be http:// \\* /diagnostics/bundle.zip. The client replaces the asterisk with the server name on which it invoked the call.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

