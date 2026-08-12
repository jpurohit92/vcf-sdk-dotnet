# Vcenter.ViJson.OpenApi.Model.QueryConnectionInfoRequestType
The parameters of *Datacenter.QueryConnectionInfo*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | The target of the query.  | 
**Port** | **int** | The port number of the target host. For ESX 2.x this is the authd port (902 by default). For ESX 3.x and above and for VMware Server hosts this is the https port (443 by default). You can specify -1 to have the vCenter Server try the default ports.  | 
**Username** | **string** | The name of the user.  | 
**Password** | **string** | The password of the user.  | 
**SslThumbprint** | **string** | The expected SSL thumbprint of the host&#39;s certificate.  | [optional] 
**SslCertificate** | **string** | The expected SSL certificate of the host in PEM format. This parameter is a fallback to be used when the certificate provided by the host can not be verified via a trusted CA. A replacement of &#x60;sslThumbprint&#x60;. Note: &#x60;sslThumbprint&#x60; and &#x60;sslCertificate&#x60; parameters are mutually exclusive, and should never be used simultaneously.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

