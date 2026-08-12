# Vcenter.ViJson.OpenApi.Model.SessionManagerHttpServiceRequestSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Method** | **string** | The HTTP method used for the request.  If null, then any method is assumed.  See also *SessionManagerHttpServiceRequestSpecMethod_enum*.  | [optional] 
**Url** | **string** | URL of the HTTP request.  E.g. &#39;https://127.0.0.1:8080/cgi-bin/vm-support.cgi?n&#x3D;val&#39;.  For ESXi CGI service requests: - only the path and query parts of the URL are used   (e.g. \&quot;/cgi-bin/vm-support.cgi?n&#x3D;val\&quot;).     This is so because the scheme is not known to the CGI service, and the port may not be the same if using a proxy.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

