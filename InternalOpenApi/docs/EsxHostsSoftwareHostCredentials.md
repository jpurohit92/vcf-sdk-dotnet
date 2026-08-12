# Vcenter.Automation.OpenApi.Model.EsxHostsSoftwareHostCredentials
The Esx.Hosts.Software.HostCredentials schema contains properties that describe the host's username, password, port number, ssl thumbprint or ssl certificate to be used when connecting to the host using USERNAME_PASSWORD option in the AuthenticationType schema.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostName** | **string** | The IP address or DNS resolvable name of the host.  This property was added in __vSphere API 7.0.2.0__. | 
**UserName** | **string** | Specifies the username to be used during the *GET /esx/software* operation  This property was added in __vSphere API 7.0.2.0__. | 
**Password** | **string** | Specifies the password to be used during the *GET /esx/software* operation  This property was added in __vSphere API 7.0.2.0__. | 
**Port** | **long** | Specifies the port number of the host to be used during *GET /esx/software* operation  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60;, port number is set to 443. | [optional] 
**SslThumbPrint** | **string** | This property is deprecated as of __vSphere API 9.0.0.0__. This field is deprecated and will be removed in future versions. Please use the &#39;ssl_certificate&#39; field instead.  Specifies the sslThumbPrint of the host to be used during *GET /esx/software* operation SHA1 hash of the host&#39;s SSL certificate.  This property was added in __vSphere API 7.0.2.0__.  If specified and the server presents that thumbprint, the connection will be established; if missing or &#x60;null&#x60;, the connection will only proceed if the server-presented certificate can be validated by specified *sslCertificate*. | [optional] 
**SslCertificate** | **string** | Specifies the sslCertificate of the host to be used during *GET /esx/software* operation PEM format of the host&#39;s SSL certificate.  This property was added in __vSphere API 9.0.0.0__.  If specified and the server presents that certificate, the connection will be established; if missing or &#x60;null&#x60;, the connection will only proceed if the server-presented thumbprint can be validated by specified *sslThumbprint*. Note: *sslThumbprint* and *sslCertificate* parameters are mutually exclusive, and should never be used simultaneously. If both are set, this operation will throw InvalidArgument exception. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

