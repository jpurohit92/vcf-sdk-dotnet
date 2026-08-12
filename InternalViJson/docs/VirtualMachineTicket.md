# Vcenter.ViJson.OpenApi.Model.VirtualMachineTicket

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ticket** | **string** | The ticket name.  This is used as the username and password for the MKS connection.  | 
**CfgFile** | **string** | The name of the configuration file for the virtual machine.  | 
**Host** | **string** | The host with which to establish a connection.  If the host is not specified, it is assumed that the requesting entity knows the appropriate host with which to connect.  | [optional] 
**Port** | **int** | The port number to use.  If the port is not specified, it is assumed that the requesting entity knows the appropriate port to use when making a new connection.  | [optional] 
**SslThumbprint** | **string** | The expected SHA1 thumbprint of the SSL cert of the host to which we are connecting.  This field can be enabled or disabled on the host.  | [optional] 
**CertThumbprintList** | [**List&lt;VirtualMachineCertThumbprint&gt;**](VirtualMachineCertThumbprint.md) | List of expected thumbprints of the certificate of the host to which we are connecting.  The list can be configured on the host to include only certain hash types. The default configuration includes all hash types that are considered secure. See vmware.com for the current security standards.  ***Since:*** vSphere API Release 7.0.3.1  | [optional] 
**SslCertificate** | **string** | PEM-encoded SSL certificate of the host to which we are connecting.  Note: *VirtualMachineTicket.sslThumbprint* and *VirtualMachineTicket.sslCertificate* parameters are mutually exclusive, and should never be used simultaneously.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**Url** | **string** | Websocket URL.  Some tickets are \&quot;websocket\&quot; tickets and are best expressed as a URL.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

