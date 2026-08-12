# Vcenter.Automation.OpenApi.Model.ApplianceLoggingForwardingConfig
The Appliance.Logging.Forwarding.Config schema defines the configuration for log message forwarding to remote logging servers.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | FQDN or IP address of the logging server to which messages are forwarded.  This property was added in __vSphere API 6.7__. | 
**Port** | **long** | The port on which the remote logging server is listening for forwarded log messages.  This property was added in __vSphere API 6.7__. | 
**Protocol** | **string** | Transport protocol used to forward log messages.  Possible values:   - &#x60;TLS&#x60;: Log messages will be forwarded to the remote host by using the TLS protocol.   - &#x60;UDP&#x60;: Log messages will be forwarded to the remote host using the UDP protocol.   - &#x60;TCP&#x60;: Log messages will be forwarded to the remote host using the TCP protocol.   For more information see: *Appliance.Logging.Forwarding.Protocol*.  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

