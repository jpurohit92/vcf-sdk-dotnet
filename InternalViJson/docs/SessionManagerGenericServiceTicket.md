# Vcenter.ViJson.OpenApi.Model.SessionManagerGenericServiceTicket

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique string identifying the ticket.  | 
**HostName** | **string** | The name of the host that the service is running on  | [optional] 
**SslThumbprint** | **string** | The expected thumbprint of the SSL certificate of the host.  If it is empty, the host must be authenticated by name.  | [optional] 
**CertThumbprintList** | [**List&lt;VirtualMachineCertThumbprint&gt;**](VirtualMachineCertThumbprint.md) | List of expected thumbprints of the certificate of the host to which we are connecting.  The list can be configured on the host to include only certain hash types. The default configuration includes all hash types that are considered secure. See vmware.com for the current security standards.  ***Since:*** vSphere API Release 7.0.3.1  | [optional] 
**SslCertificate** | **string** | Supported only by vCenter.  The expected SSL certificate of the host to which we are connecting to, in PEM format. Note: *SessionManagerGenericServiceTicket.sslThumbprint* and *SessionManagerGenericServiceTicket.sslCertificate* parameters are mutually exclusive, and should never be used simultaneously.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**TicketType** | **string** | Type of the ticket See { @Vim::SessionManager::GenericServiceTicket::TicketType }  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

