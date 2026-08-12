# Vcenter.ViJson.OpenApi.Model.ServiceLocator

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstanceUuid** | **string** | Unique ID of the instance to which the service belongs.  For instances that support the vSphere API, this is the same as the value found in *AboutInfo.instanceUuid*.  | 
**Url** | **string** | URL used to access the service endpoint  | 
**Credential** | [**ServiceLocatorCredential**](ServiceLocatorCredential.md) | Credential to establish the connection and login to the service.  | 
**SslThumbprint** | **string** | The SSL thumbprint of the certificate of the service endpoint.  Superseded by *ServiceLocator.sslCertificate*. Note: If both &lt;code&gt;sslThumbprint&lt;/code&gt; and &lt;code&gt;sslCertificate&lt;/code&gt; are set, &lt;code&gt;sslThumbprint&lt;/code&gt; must correspond to the &lt;code&gt;sslCertificate&lt;/code&gt;.  | [optional] 
**SslCertificate** | **string** | The SSL certificate of the service endpoint in PEM format.  A replacement for *ServiceLocator.sslThumbprint*. Note: If both &lt;code&gt;sslThumbprint&lt;/code&gt; and &lt;code&gt;sslCertificate&lt;/code&gt; are set, &lt;code&gt;sslThumbprint&lt;/code&gt; must correspond to the &lt;code&gt;sslCertificate&lt;/code&gt;.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

