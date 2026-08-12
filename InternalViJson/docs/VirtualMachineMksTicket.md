# Vcenter.ViJson.OpenApi.Model.VirtualMachineMksTicket

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ticket** | **string** | The ticket name.  This is used as the username and password for the MKS connection.  | 
**CfgFile** | **string** | The name of the configuration file for the virtual machine.  | 
**Host** | **string** | The host with which to establish a connection.  If the host is not specified, it is assumed that the requesting entity knows the appropriate host with which to connect.  | [optional] 
**Port** | **int** | The port number to use.  If the port is not specified, it is assumed that the requesting entity knows the appropriate port to use when making a new connection.  | [optional] 
**SslThumbprint** | **string** | The expected thumbprint of the SSL cert of the host to which we are connecting.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

