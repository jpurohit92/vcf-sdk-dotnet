# Vcenter.ViJson.OpenApi.Model.HostServiceTicket

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | **string** | The name of the host providing the service for which the ticket applies.  If omitted, then the client uses the host name for the server that issued the ticket.  | [optional] 
**Port** | **int** | Access to some services is made possible by connecting to a port on a server.  If the service for which a ticket is issued is available on a particular port, that port number is specified with this property. If omitted, except in the case of connecting to CIM interfaces, the port number for the service that issued the ticket is used. In the case of connecting to a CIM interface the standard well known port for the particular service will be used for the connection.  | [optional] 
**SslThumbprint** | **string** | The expected thumbprint of the SSL cert of the host to which we are connecting.  | [optional] 
**SslCertificate** | **string** | PEM-encoded SSL certificate of the host to which we are connecting.  Note: *HostServiceTicket.sslThumbprint* and *HostServiceTicket.sslCertificate* parameters are mutually exclusive, and should never be used simultaneously.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**Service** | **string** | The name of the service to which to connect.  | 
**ServiceVersion** | **string** | A dot-separated string identifying the service protocol version.  For example, 1.0 is used for NFC hosted by vpxa on ESX 2.5, and 1.1 is used for NFC hosted by hostd on ESX 3.0.  | 
**SessionId** | **string** | An identifying string for the session created for the ticketed connection.  This is used by the host service to identify the operations permitted within the session.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

